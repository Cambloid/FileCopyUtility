using Base;
using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
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

        #region Private vars

        private LiteDatabase db;

        #endregion

        #region Construktor

        public FrmMain()
        {
            InitializeComponent();

            this.trvFiles.PathSeparator = @"\";

            this.fillPathFields();
            this.updateStatus();

            if(this.state == FormState.Ready)
            {
                // Load database or create if it doesnt exist
                this.setDatabase();

                // Load all packages from db
                this.loadPackages();
            }
        }

        #endregion

        #region Private methods

        private void importPkgZip(string file)
        {
            // should be async

        }

        private void setFieldsByStatus()
        {
            // pkg actions
            this.btnCreate.Enabled = this.state == FormState.Ready;
            this.btnImport.Enabled = this.state == FormState.Ready;
            this.btnRemove.Enabled = this.state == FormState.Ready;

            // Pkg info
            this.lstPackages.Enabled = this.state == FormState.Ready;
            this.trvFiles.Enabled = this.state == FormState.Ready;
            this.txtPkgPath.Enabled = this.state == FormState.Ready;
            this.txtPkgName.Enabled = this.state == FormState.Ready;
            this.btnBrowsePkg.Enabled = this.state == FormState.Ready;
            this.lstCredits.Enabled = this.state == FormState.Ready;

            // Pkg ops
            this.btnRefresh.Enabled = this.state == FormState.Ready;
            this.btnRemovePkg.Enabled = this.state == FormState.Ready;
            this.btnInstallPkg.Enabled = this.state == FormState.Ready;

        }

        private void fillPathFields()
        {
            string dbPath = Properties.Settings.Default.DbPath;
            string gameRoot = Properties.Settings.Default.GameRoot;
            string storage = Properties.Settings.Default.StoragePath;
            string backup = Properties.Settings.Default.BackupPath;


            this.txtDbFile.Text = dbPath;
            this.txtGameRoot.Text = gameRoot;
            this.txtStoragePath.Text = storage;
            this.txtBackupDir.Text = backup;


        }

        private void updateStatus()
        {
            // Update app status
            this.state = FormState.Ready;

            string dbPath   = Properties.Settings.Default.DbPath;
            string gameRoot = Properties.Settings.Default.GameRoot;
            string storage  = Properties.Settings.Default.StoragePath;
            string backup   = Properties.Settings.Default.BackupPath;

            if(dbPath == string.Empty)
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

            this.setFieldsByStatus();
        }

        private void setDatabase()
        {
            if (this.state != FormState.Ready)
            {
                return;
            }

            string dbPath = Properties.Settings.Default.DbPath;
            this.db = new LiteDatabase(dbPath);

        }

        private void loadPackages()
        {
            // Get Packages
            var col = db.GetCollection<Package>("Package");
            
            // Check if db has packages
            if(col.Count() <= 0)
            {
                return;
            }
            
            var results = col.FindAll().ToList();

            foreach(Package pkg in results)
            {
                ListViewItem item = new ListViewItem(pkg.Name);
                item.Tag = pkg;

                this.lstPackages.Items.Add(item);

            }

        }

        private void loadFilesBySelectedPackage(Package pkg)
        {
            var col = db.GetCollection<PackageFile>("PackageFile");

            // Check if db has packages
            if (col.Count() <= 0)
            {
                return;
            }

            var results = col.Query().Where(x => x.Pkg.Name == pkg.Name).OrderBy(x => x.RelPath).ToList();

            TreeNode lastNode = null;
            string subPathAgg;
            foreach (PackageFile file in results)
            {
                subPathAgg = string.Empty;
                foreach (string subPath in file.RelPath.Split('\\'))
                {

                    subPathAgg += subPath + '\\';
                    TreeNode[] nodes = this.trvFiles.Nodes.Find(subPathAgg, true);

                    if (nodes.Length == 0)
                    {
                        if (lastNode == null)
                        {
                            lastNode = this.trvFiles.Nodes.Add(subPathAgg, subPath);
                        }
                        else
                        {
                            lastNode = lastNode.Nodes.Add(subPathAgg, subPath);
                        }
                    }
                    else
                    {
                        lastNode = nodes[0];
                    }
                }
            }
        }

        #endregion

        #region Events

        private void btnNewProjectFile_Click(object sender, EventArgs e)
        {
            string file = Utility.PickFolder();
            if (file != string.Empty)
            {

                this.txtDbFile.Text = file;
                Properties.Settings.Default.DbPath = file;
                Properties.Settings.Default.Save();

                this.updateStatus();
                this.setDatabase();
            }
        }

        private void btnBrowseDbFile_Click(object sender, EventArgs e)
        {
            string file = Utility.PickFile();

            if (file != string.Empty)
            {
                this.txtDbFile.Text = file;
                Properties.Settings.Default.DbPath = file;
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (this.state != FormState.Ready)
            {
                return;
            }

            using (FrmInput input = new FrmInput())
            {
                DialogResult res = input.ShowDialog(this);
                if (res == DialogResult.Yes && input.InputText != string.Empty)
                {
                    // TODO: Create new package
                    Package newPkg = new Package();
                    newPkg.Name = input.InputText;
                    newPkg.Path = string.Empty;


                    var col = db.GetCollection<Package>("Package");
                    col.Insert(newPkg);

                    this.loadPackages();
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (this.state != FormState.Ready)
            {
                return;
            }
            string file = Utility.PickFile();

            if (file != string.Empty)
            {
                this.importPkgZip(file);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.state == FormState.Ready)
            {

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (this.state == FormState.Ready)
            {

            }
        }

        private void btnInstallPkg_Click(object sender, EventArgs e)
        {
            if (this.state == FormState.Ready)
            {

            }
        }

        private void btnRemovePkg_Click(object sender, EventArgs e)
        {
            if (this.state == FormState.Ready)
            {

            }
        }

        private void cmiAdd_Click(object sender, EventArgs e)
        {
            if (this.state == FormState.Ready)
            {

            }
        }

        private void cmiRemove_Click(object sender, EventArgs e)
        {
            if (this.state == FormState.Ready)
            {

            }
        }

        private void lstPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstPackages.SelectedItems.Count <= 0)
            {
                return;
            }

            ListViewItem item = (ListViewItem)this.lstPackages.SelectedItems[0];

            if(item != null)
            {
                this.loadFilesBySelectedPackage((Package)item.Tag);
            }

        }


        #endregion

    }
}
