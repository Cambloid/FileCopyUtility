using Base;
using ContentManager.Data;
using System;
using System.Collections.Concurrent;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentManager
{
    public partial class FrmMain : Form
    {

        #region Enums

        private enum FormState
        {
            Ready,
            NotReady
        }

        private FormState state = FormState.NotReady;

        #endregion

        #region Private Vars

        Project project;

        #endregion

        #region Construktor

        public FrmMain()
        {
            InitializeComponent();

            this.fillPathFields();
            this.updateStatus();

            if (this.state == FormState.Ready)
            {
                // Load database or create if it doesnt exist
                this.setDatabase();

                PkgConflict conflicts = new PkgConflict(this.project);
                conflicts.Dock = DockStyle.Fill;
                this.tbPkgConflict.Controls.Add(conflicts);

                Packages pkgs = new Packages(this.project);
                pkgs.Dock = DockStyle.Fill;
                this.tbContent.Controls.Add(pkgs);


                ModDevelop mod = new ModDevelop();
                mod.Dock = DockStyle.Fill;
                this.tbModDevFiles.Controls.Add(mod);
            }

            
        }

        #endregion

        #region Private methods

        private void fillPathFields()
        {
            string dbPath = Properties.Settings.Default.ProjectRoot;
            string gameRoot = Properties.Settings.Default.GameRoot;
            string storage = Properties.Settings.Default.StoragePath;
            string backup = Properties.Settings.Default.BackupPath;


            this.txtProjectRoot.Text = dbPath;
            this.txtGameRoot.Text = gameRoot;
            this.txtStoragePath.Text = storage;
            this.txtBackupDir.Text = backup;


        }

        private void updateStatus()
        {
            // Update app status
            this.state = FormState.Ready;

            string projectRoot   = Properties.Settings.Default.ProjectRoot;
            string gameRoot = Properties.Settings.Default.GameRoot;
            string storage  = Properties.Settings.Default.StoragePath;
            string backup   = Properties.Settings.Default.BackupPath;

            if(projectRoot == string.Empty || !Directory.Exists(projectRoot))
            {
                this.state = FormState.NotReady;
            }

            if(!Directory.Exists(gameRoot) && Utility.IsGameRootFolderValid(gameRoot))
            {
                this.state = FormState.NotReady;
            }

            if(!Directory.Exists(storage))
            {
                this.state = FormState.NotReady;
            }

            if(backup == string.Empty)
            {
                // Autofill backup dir
                string defPath = ".\\Backup";

                Properties.Settings.Default.BackupPath = defPath;
                Properties.Settings.Default.Save();

                this.txtBackupDir.Text = defPath;
            }

        }

        private bool setDatabase()
        {
            if (this.state != FormState.Ready)
            {
                return false;
            }

            try
            {
                string dbPath = Properties.Settings.Default.ProjectRoot;

               if(!Directory.Exists(dbPath))
                {
                    return false;
                }

                this.project = new Project(dbPath);

                return true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                Properties.Settings.Default.ProjectRoot = string.Empty;
                Properties.Settings.Default.Save();

            }


            return false;
        }

        #endregion

        #region Events

        private void btnBrowseDbFile_Click(object sender, EventArgs e)
        {
            string file = Utility.PickFolder();
            if (file != string.Empty)
            {
                this.txtProjectRoot.Text = file;

                Properties.Settings.Default.ProjectRoot = file;
                Properties.Settings.Default.Save();

                this.updateStatus();
                this.setDatabase();
            }
        }

        private void btnBrowseGameRoot_Click(object sender, EventArgs e)
        {
            string folder = Utility.PickFolder();

            if (folder != string.Empty)
            {
                this.txtGameRoot.Text = folder;
                Properties.Settings.Default.GameRoot = folder;
                Properties.Settings.Default.Save();

                this.updateStatus();
            }

        }

        private void btnBrowseStorage_Click(object sender, EventArgs e)
        {
            string folder = Utility.PickFolder();

            if (folder != string.Empty)
            {
                this.txtStoragePath.Text = folder;
                Properties.Settings.Default.StoragePath = folder;
                Properties.Settings.Default.Save();

                this.updateStatus();
            }

        }

        private void btnBackupDir_Click(object sender, EventArgs e)
        {
            string folder = Utility.PickFolder();

            if (folder != string.Empty)
            {
                this.txtBackupDir.Text = folder;
                Properties.Settings.Default.BackupPath = folder;
                Properties.Settings.Default.Save();

                this.updateStatus();
            }

        }

        #endregion

    }
}
