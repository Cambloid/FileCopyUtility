using Base;
using LiteDB;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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

        #region Construktor

        public FrmMain()
        {
            InitializeComponent();

            this.trvFiles.PathSeparator = @"\";

            this.fillPathFields();
            this.updateStatus();

            if (this.state == FormState.Ready)
            {
                // Load database or create if it doesnt exist
                this.setDatabase();

                // Load all packages from db
                this.loadPackages();


            }
        }

        #endregion

        #region Private methods

        private void importPkgDir(string dir, string pkgName)
        {
            try
            {

                if (!Directory.Exists(dir))
                {
                    return;
                }


                string[] files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
                ConcurrentDictionary<string, string> fileHashes = new ConcurrentDictionary<string, string>();

                Parallel.For(0, files.Length,
                       index =>
                       {
                           FileInfo fi = new FileInfo(files[index]);
                           using (FileStream stream = File.OpenRead(files[index]))
                           {
                               var sha = new SHA256Managed();
                               byte[] checksum = sha.ComputeHash(stream);

                               fileHashes.TryAdd(BitConverter.ToString(checksum).Replace("-", String.Empty), files[index]);

                           }
                       });


                using (var db = new LiteDatabase(Properties.Settings.Default.DbPath))
                {

                    var packages = db.GetCollection<Package>("Package_Table");
                    int nextId = packages.Count();

                    if (files.Count() != fileHashes.Count())
                    {
                        return;
                    }

                    Package pkg = new Package();
                    pkg.PkgId   = nextId;
                    pkg.Name    = pkgName;
                    pkg.Path    = dir;
                    pkg.Credits = new string[] { "" };

                    packages.Insert(pkg);


                    var col = db.GetCollection<PackageFile>("PackageFile_Table");



                    for (int i = 0; i < fileHashes.Count(); i++)
                    {
                        PackageFile pkgFile = new PackageFile();

                        pkgFile.FileId = col.Count();
                        pkgFile.Sha256Hash = fileHashes.ElementAt(i).Key;
                        pkgFile.RelPath = fileHashes.ElementAt(i).Value;
                        pkgFile.PackageFK = nextId;

                        col.Insert(pkgFile);
                    }


                }


                // 2. iterate through each file and generate hash and add to database
                // 3. add info like path, name, hash of each file in db



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
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

        private bool setDatabase()
        {

            if (this.state != FormState.Ready)
            {
                return false;
            }

            try
            {
                string dbPath = Properties.Settings.Default.DbPath;

               if(!File.Exists(dbPath))
                {
                    return false;
                }
                

                return true;

            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                Properties.Settings.Default.DbPath = string.Empty;
                Properties.Settings.Default.Save();

            }


            return false;
        }

        private void loadPackages()
        {
            this.lstPackages.Items.Clear();

            using (var db = new LiteDatabase(Properties.Settings.Default.DbPath))
            {
                // Get Packages
                var col = db.GetCollection<Package>("Package_Table");


                // Check if db has packages
                if (col.Count() <= 0)
                {
                    return;
                }

                var results = col.FindAll();

                foreach (Package pkg in results)
                {
                    ListViewItem item = new ListViewItem(pkg.Name);
                    item.Tag = pkg;

                    this.lstPackages.Items.Add(item);
                }
            }
        }

        private void loadFilesBySelectedPackage(Package pkg)
        {
            this.trvFiles.Nodes.Clear();

            using (var db = new LiteDatabase(Properties.Settings.Default.DbPath))
            {
                var col = db.GetCollection<PackageFile>("PackageFile_Table");

                // Check if db has packages
                if (col.Count() <= 0)
                {
                    return;
                }

                var results = col.Query().Where(x => x.PackageFK == pkg.PkgId).OrderBy(x => x.RelPath).ToList();

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
        }

        private void removeFilesByPackageId(int packageId)
        {
            using (LiteDatabase db = new LiteDatabase(Properties.Settings.Default.DbPath))
            {
                var col = db.GetCollection<PackageFile>("PackageFile_Table");
                col.DeleteMany(x => x.PackageFK == packageId);
            }
        }

        private void removePackageById(int packageId)
        {
            using (LiteDatabase db = new LiteDatabase(Properties.Settings.Default.DbPath))
            {
                var col = db.GetCollection<Package>("Package_Table");
                col.DeleteMany(x => x.PkgId == packageId);
            }
        }

        private void selectFirstPackage()
        {
            if (this.lstPackages.Items.Count <= 0)
            {
                this.trvFiles.Nodes.Clear();
            }
            else
            {
                Package pkg = (Package)this.lstPackages.Items[0].Tag;
                this.loadFilesBySelectedPackage(pkg);
            }

        }

        #endregion

        #region Events

        private void btnNewProjectFile_Click(object sender, EventArgs e)
        {
            string file = Utility.SaveFile("Database (*.db)|*.db");
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

                    using (var db = new LiteDatabase(Properties.Settings.Default.DbPath))
                    {
                        var col = db.GetCollection<Package>("Package");
                        col.Insert(newPkg);
                    }

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

            string folder = Utility.PickFolder();
            if(folder == string.Empty)
            {
                return;
            }

            var info = new FileInfo(folder);
            string name = info.Name;

            using (FrmInput pkgName = new FrmInput())
            {
                pkgName.ShowDialog(this);
                if (pkgName.DialogResult == DialogResult.Yes)
                {
                    name = pkgName.InputText;
                }
            }

            if (folder != string.Empty)
            {
                this.importPkgDir(folder, name);
                this.loadPackages();
                this.selectFirstPackage();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.state == FormState.Ready)
            {
                if(this.lstPackages.SelectedItems.Count > 0 )
                {
                    try
                    {
                        Package pkg = (Package)this.lstPackages.SelectedItems[0].Tag;

                        this.removeFilesByPackageId(pkg.PkgId);

                        this.removePackageById(pkg.PkgId);

                        this.loadPackages();



                        this.selectFirstPackage();

                        

                    } catch (Exception ex )
                    {
                        Console.WriteLine(ex.ToString());
                    }
                                  

                }


            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.updateStatus();

            if (this.state == FormState.Ready)
            {
                this.loadPackages();
            }
        }

        private void btnInstallPkg_Click(object sender, EventArgs e)
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
