using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopyUtility
{
    
    public partial class FrmMain : Form
    {

        #region Enum

        enum ToolState
        {
            Ready,
            NeedsPaths,
            Initializing
        }

        private FilePair.FileCoherentStatus fileSelectionStatus = FilePair.FileCoherentStatus.None;

        #endregion

        #region Private vars

        private ToolState currState = ToolState.Initializing;

        private string exePath = Directory.GetCurrentDirectory();

        private FileList relFilePathList;

        #endregion

        #region Konstruktor

        public FrmMain()
        {
            InitializeComponent();


            this.relFilePathList = new FileList();
            

            if (Properties.Settings.Default.PathBackupDir == string.Empty)
            {
                Properties.Settings.Default.PathBackupDir = Directory.GetCurrentDirectory();
                Properties.Settings.Default.Save();
            }


            this.updateToolState();
            this.fillFields();
        }

        #endregion

        #region Private methods

        private void fillFields()
        {

            this.relFilePathList.LoadFromFile(Properties.Settings.Default.PathFileList);


            this.txtPathRepo.Text = Properties.Settings.Default.PathRepo;
            this.txtGameRoot.Text = Properties.Settings.Default.PathGameRoot;
            this.txtFileList.Text = Properties.Settings.Default.PathFileList;
            this.txtBackupDir.Text = Properties.Settings.Default.PathBackupDir;

            if (this.currState != ToolState.Ready)
            {
                return;
            }

            ConcurrentBag<ListViewItem> itemCollection = new ConcurrentBag<ListViewItem>();
            Parallel.ForEach(
                 this.relFilePathList.Files,
                 (baseRelativeFilePath) =>
                 {
                     FilePair pair = new FilePair(baseRelativeFilePath);
                     FilePair.FileCoherentStatus fileStatus = pair.GetFilePairStatus();

                     string statusText = string.Empty;
                     Color rowColor = Color.White;

                     switch (fileStatus)
                     {
                         case FilePair.FileCoherentStatus.FilesAreEven:
                             if (!this.chkFilesEven.Checked) { return; }
                             statusText = "File are even";
                             rowColor = Color.White;
                             break;
                         case FilePair.FileCoherentStatus.GameRootAndRepoIsMissing:
                             if (!this.chkGameRootAndRepoMissing.Checked) { return; }
                             statusText = "Gameroot and Repo is missing";
                             rowColor = Color.Red;
                             break;
                         case FilePair.FileCoherentStatus.GameRootIsMissing:
                             if (!this.chkGameRootIsMissing.Checked) { return; }
                             statusText = "File in game root is missing";
                             rowColor = Color.Yellow;
                             break;
                         case FilePair.FileCoherentStatus.GameRootIsNewer:
                             if (!this.chkGameRootIsNewer.Checked) { return; }
                             statusText = "File in gameroot is newer";
                             rowColor = Color.Yellow;
                             break;
                         case FilePair.FileCoherentStatus.RepositoryIsMissing:
                             if (!this.chkRepoIsMissing.Checked) { return; }
                             statusText = "File in repo is missing";
                             rowColor = Color.Yellow;
                             break;
                         case FilePair.FileCoherentStatus.RepositoryIsNewer:
                             if (!this.chkRepoIsNewer.Checked) { return; }
                             statusText = "File in repository is newer";
                             rowColor = Color.Yellow;
                             break;
                         case FilePair.FileCoherentStatus.None:
                             return;
                     }

                     if (this.chkSearchFilter.Checked)
                     {
                         if (!baseRelativeFilePath.ToLower().Contains(this.txtSearch.Text.ToLower()))
                         {
                             return;
                         }
                     }

                     ListViewItem item = new ListViewItem(
                         new string[] {
                            baseRelativeFilePath,
                            pair.GetRepositoryFileInfo().LastAccessTime.ToString(),
                            pair.GetGameRootFileInfo().LastAccessTime.ToString(),
                            statusText
                         }
                         );

                     item.BackColor = rowColor;
                     item.Tag = pair;

                     itemCollection.Add(item);
                 });

            this.listFiles.Items.Clear();
            this.listFiles.Items.AddRange(itemCollection.ToArray());
            
        }
        
        private void updateToolState()
        {


            bool isGameRootValid = this.validateGameRootFolder();

            if (this.checkBasePathsExist() && isGameRootValid)
            {
                this.currState = ToolState.Ready;
            }
            else
            {
                this.currState = ToolState.NeedsPaths;
            }


            this.btnAddFile.Enabled = this.currState == ToolState.Ready;

            this.btnRemoveFile.Enabled = 
                this.currState == ToolState.Ready && 
                this.listFiles.SelectedItems.Count > 0;

            this.btnRefresh.Enabled = this.currState == ToolState.Ready;

            this.btnCopyToGameRoot.Enabled = 
                this.currState == ToolState.Ready && 
                this.fileSelectionStatus != FilePair.FileCoherentStatus.RepositoryIsMissing &&
                this.fileSelectionStatus != FilePair.FileCoherentStatus.None;

            this.btnCopyToRepo.Enabled =
                this.currState == ToolState.Ready && 
                this.fileSelectionStatus != FilePair.FileCoherentStatus.GameRootIsMissing &&
                this.fileSelectionStatus != FilePair.FileCoherentStatus.None;

            this.btnCompare.Enabled = 
                this.currState == ToolState.Ready &&
                this.listFiles.SelectedItems.Count == 1;


        }

        private bool checkBasePathsExist()
        {
            return 
                Directory.Exists(Properties.Settings.Default.PathRepo) && 
                Directory.Exists(Properties.Settings.Default.PathGameRoot) && 
                File.Exists(Properties.Settings.Default.PathFileList);
        }

        private bool fileAlreadyExistInConfig(string baseRelativePath)
        {
            return relFilePathList.CheckIfFileExistsInList(baseRelativePath);
        }

        private void createDirsIfNotExists(string dirPath)
        {
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
        }

        private bool validateGameRootFolder()
        {
            bool isValid = false;

            string gameRootDir = Properties.Settings.Default.PathGameRoot;

            isValid =
                Directory.Exists(FilePair.AdvancedPathCombine(gameRootDir, "usermaps")) &&
                Directory.Exists(FilePair.AdvancedPathCombine(gameRootDir, "share")) &&
                Directory.Exists(FilePair.AdvancedPathCombine(gameRootDir, "model_export")) &&
                Directory.Exists(FilePair.AdvancedPathCombine(gameRootDir, "xanim_export")) &&
                Directory.Exists(FilePair.AdvancedPathCombine(gameRootDir, "source_data")) &&
                Directory.Exists(FilePair.AdvancedPathCombine(gameRootDir, "texture_assets")) &&
                Directory.Exists(FilePair.AdvancedPathCombine(gameRootDir, "sound_assets"));

            return isValid;
        }
        

        #endregion

        #region Events

        private void btnBrowseRepo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            DialogResult res = dlg.ShowDialog();
            if(res == DialogResult.OK)
            {
                Properties.Settings.Default.PathRepo = dlg.SelectedPath;
                Properties.Settings.Default.Save();

                this.updateToolState();
                this.fillFields();
            }

        }

        private void btnBrowseGameRoot_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                Properties.Settings.Default.PathGameRoot = dlg.SelectedPath;
                Properties.Settings.Default.Save();

                this.updateToolState(); 
                this.fillFields();
            }
        }

        private void btnBrowseFileList_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult res = dlg.ShowDialog();

            if (res == DialogResult.OK)
            {
                Properties.Settings.Default.PathFileList = dlg.FileName;
                Properties.Settings.Default.Save();

                this.updateToolState();
                this.fillFields();
            }
        }

        private void btnNewFileList_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            DialogResult res = dlg.ShowDialog();

            if (res == DialogResult.OK)
            {
                Properties.Settings.Default.PathFileList = dlg.FileName;
                Properties.Settings.Default.Save();

                File.Create(dlg.FileName,1);

                this.updateToolState();
                this.fillFields();
            }

        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;

            DialogResult res = dlg.ShowDialog();

            if(res == DialogResult.OK)
            {
                foreach (string file in dlg.FileNames)
                {

                    string baseRelPath = FilePair.GetBaseRelativePath(file);


                    if (this.fileAlreadyExistInConfig(baseRelPath))
                    {
                        MessageBox.Show(
                            "File " + baseRelPath + " is already in the list.",
                            "Error",
                            MessageBoxButtons.OK);
                        continue;
                    }

                   this.relFilePathList.Files.Add(baseRelPath);
                   this.relFilePathList.SaveToFile(Properties.Settings.Default.PathFileList);

                }
                this.fillFields();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.fillFields();
        }

        private void btnCopyToGameRoot_Click(object sender, EventArgs e)
        {
            FileBackup backup;
            FilePair pair;
            foreach (ListViewItem item in this.listFiles.SelectedItems)
            {
                pair = (FilePair)item.Tag;
                try
                {
                    backup = new FileBackup(FileBackup.BackupLocation.GameRoot);
                    backup.DoBackup(pair);

                    string gamerootDirPath = Path.GetDirectoryName(pair.GetGameRootFileInfo().FullName);
                    this.createDirsIfNotExists(gamerootDirPath);

                    File.Copy(pair.GetRepositoryFileInfo().FullName, pair.GetGameRootFileInfo().FullName, true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            this.fillFields();
        }

        private void btnCopyToRepo_Click(object sender, EventArgs e)
        {
            FileBackup backup;
            FilePair pair;
            foreach (ListViewItem item in this.listFiles.SelectedItems)
            {
                pair = (FilePair)item.Tag;
                try
                {
                    backup = new FileBackup(FileBackup.BackupLocation.Repository);
                    backup.DoBackup(pair);

                    string repoDirPath = Path.GetDirectoryName(pair.GetRepositoryFileInfo().FullName);
                    this.createDirsIfNotExists(repoDirPath);


                    File.Copy(pair.GetGameRootFileInfo().FullName, pair.GetRepositoryFileInfo().FullName, true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            this.fillFields();
        }
        
        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            if(this.listFiles.SelectedItems.Count <= 0)
            {
                return;
            }

            List<string> entriesToRemove = new List<string>();
            foreach (ListViewItem item in this.listFiles.SelectedItems)
            {
                entriesToRemove.Add(item.SubItems[0].Text);
            }

            foreach(string entry in entriesToRemove)
            {
                this.relFilePathList.Files.Remove(entry);
            }

            this.relFilePathList.SaveToFile(Properties.Settings.Default.PathFileList);

            this.fillFields();
        }

        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fileSelectionStatus = FilePair.FileCoherentStatus.None;


            if (this.listFiles.SelectedItems.Count == 1)
            {
                FilePair pair = (FilePair)this.listFiles.SelectedItems[0].Tag;
                this.fileSelectionStatus = pair.GetFilePairStatus();

            }
            else if (this.listFiles.SelectedItems.Count > 1)
            {

                // When a file pair status is different then set the status to none so no file operation butten is enabled
                FilePair pair = (FilePair)this.listFiles.SelectedItems[0].Tag;
                FilePair.FileCoherentStatus fileStatus = pair.GetFilePairStatus();
                foreach (ListViewItem item in this.listFiles.SelectedItems)
                {
                    pair = (FilePair)item.Tag;

                    if (pair == null || fileStatus != pair.GetFilePairStatus())
                    {
                        this.fileSelectionStatus = FilePair.FileCoherentStatus.None;
                        this.updateToolState();
                        return;
                    }
                }
                this.fileSelectionStatus = fileStatus;
            }

            this.updateToolState();
        }

        private void btnAddUnlisted_Click(object sender, EventArgs e)
        {
            using (FrmRepoFileFinder dlg = new FrmRepoFileFinder(this.relFilePathList))
            {
                DialogResult res = dlg.ShowDialog();
                if(res == DialogResult.OK)
                {
                    this.fillFields();
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (FrmAbout frm = new FrmAbout())
            {
                frm.ShowDialog();
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string winMergeExe = ".\\WinMerge\\WinMergeU.exe";
            if (File.Exists(winMergeExe)) {

                if (this.listFiles.SelectedItems.Count == 1)
                {

                    FilePair pair = (FilePair)this.listFiles.SelectedItems[0].Tag;

                    StringBuilder arguments = new StringBuilder();
                    arguments.Append(" ");
                    arguments.Append("/e"); // Exit app via esc key
                    arguments.Append(" ");
                    arguments.Append("/fr"); // Sets focus on the right side
                    arguments.Append(" ");
                    arguments.Append("\"" + pair.GetRepositoryFileInfo().FullName + "\"");
                    arguments.Append(" ");
                    arguments.Append("\"" + pair.GetGameRootFileInfo().FullName + "\"");


                    Process.Start(winMergeExe, arguments.ToString());

                } else
                {
                    MessageBox.Show("Please select one entry.");
                }
            } else
            {
                MessageBox.Show("WinMerge is not installed. Extract the WinMerge folder next to the executable.");
            }
        }

        #endregion

    }
}
