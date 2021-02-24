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

        private void importPkgDir(string pkgDir, string pkgName)
        {
            try
            {
                if (!Directory.Exists(pkgDir))
                {
                    return;
                }

                string[] files = Directory.GetFiles(pkgDir, "*.*", SearchOption.AllDirectories);
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

                Package pkg = new Package(pkgName, this.project.GetPackages().Count());
                pkg.Path = pkgDir;
                pkg.Credits = new string[0];


                for (int i = 0; i < fileHashes.Count(); i++)
                {
                    PackageFile pkgFile = new PackageFile();

                    pkg.ByteSize += new FileInfo(fileHashes.ElementAt(i).Value).Length;

                    pkgFile.FileId = pkg.FileCollection.Count();
                    pkgFile.Sha256 = fileHashes.ElementAt(i).Key;
                    pkgFile.RelPath = Utility.StringDelta(pkgDir, fileHashes.ElementAt(i).Value);
                    pkgFile.PackageFK = pkg.PkgId;

                    pkg.FileCollection.Add(pkgFile);
                }


                this.project.AddPkg(pkg);


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

        private void loadPackages()
        {

            if(this.state != FormState.Ready)
            {
                return;
            }

            this.lstPackages.Items.Clear();

            foreach (Package pkg in this.project.GetPackages())
            {
                ListViewItem item = new ListViewItem(pkg.Name);
                item.Tag = pkg;
                this.lstPackages.Items.Add(item);
            }
        }

        private void setFieldsBySelectedPackage(Package pkg)
        {
            this.txtPkgPath.Text = pkg.Path;
            if(Directory.Exists(pkg.Path))
            {
                this.txtPkgPath.BackColor = Color.White;
            } else
            {
                this.txtPkgPath.BackColor = Color.Red;
            }

            this.txtPkgName.Text = pkg.Name;
            this.txtPkgId.Text = pkg.PkgId.ToString();
            this.txtPkgSize.Text = pkg.ByteSize.ToString() + " Bytes";

            this.lstCredits.Items.Clear();
            foreach(string credit in pkg.Credits)
            {
                this.lstCredits.Items.Add(credit);
            }



            this.trvFiles.Nodes.Clear();

            TreeNode lastNode = null;
            string subPathAgg = string.Empty;

            foreach (PackageFile file in pkg.FileCollection)
            {
                subPathAgg = string.Empty;
                bool first = true;
                foreach (string subPath in file.RelPath.Split('\\'))
                {
                    string nodeName = string.Empty;
                    if(subPath == string.Empty || first)
                    {
                        nodeName = pkg.Name;
                    } else
                    {
                        nodeName = subPath;
                    }
                    first = false;

                    subPathAgg += nodeName + '\\';
                    TreeNode[] nodes = this.trvFiles.Nodes.Find(subPathAgg, true);

                    if (nodes.Length == 0)
                    {
                        if (lastNode == null)
                        {
                            lastNode = this.trvFiles.Nodes.Add(subPathAgg, nodeName);
                        }
                        else
                        {
                            lastNode = lastNode.Nodes.Add(subPathAgg, nodeName);
                        }
                    }
                    else
                    {
                        lastNode = nodes[0];
                    }
                }
            }

        }

        private void removePackageById(int packageId)
        {
            this.project.RemovePkg(packageId);

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
                this.setFieldsBySelectedPackage(pkg);
            }
        }

        private void btnCheckPkg_Click(object sender, EventArgs e)
        {
            ConflictSearcher searcher = new ConflictSearcher(this.project);
            var conflicts = searcher.FindConflicts();

            this.trvConflicts.Nodes.Clear();
            foreach(var conflict in conflicts)
            {
                TreeNode node = new TreeNode("File: " + conflict.Group[0].Item2.RelPath);
                foreach(var group in conflict.Group)
                {
                    node.Nodes.Add(new TreeNode("In Package: " + group.Item1.Name));
                }
                this.trvConflicts.Nodes.Add(node);
            }

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
                    //Package newPkg = new Package(input.InputText, this.project.GetPackages().Count());
                    //newPkg.Path = string.Empty;

                    this.project.CreatePkg(input.InputText);


                    //using (var db = new LiteDatabase(Properties.Settings.Default.DbPath))
                    //{
                    //    var col = db.GetCollection<Package>("Package");
                    //    col.Insert(newPkg);
                    //}

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

                this.project.Save();
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

                        //this.removeFilesByPackageId(pkg.PkgId);

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
            if (this.state != FormState.Ready)
            {
                return;
            }
            if (this.lstPackages.SelectedItems.Count <= 0)
            {
                return;
            }

            

            using (FrmInput creditName = new FrmInput())
            {
                creditName.ShowDialog(this);
                if (creditName.DialogResult == DialogResult.Yes)
                {
                    this.lstCredits.Items.Add(creditName.InputText);
                }
            }

        }

        private void cmiRemove_Click(object sender, EventArgs e)
        {
            if (this.state != FormState.Ready)
            {
                return;
            }
            if (this.lstCredits.SelectedItems.Count <= 0)
            {
                return;
            }

            this.lstCredits.Items.RemoveAt(this.lstCredits.SelectedIndex);

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
                this.setFieldsBySelectedPackage((Package)item.Tag);
            }
        }

        private void txtPkgName_TextChanged(object sender, EventArgs e)
        {
            if (this.lstPackages.SelectedItems.Count <= 0)
            {
                return;
            }

            if(this.state != FormState.Ready)
            {
                return;
            }

            Package pkg = (Package)this.lstPackages.SelectedItems[0].Tag;
            if(this.txtPkgName.Text != string.Empty)
            {
                pkg.Name = this.txtPkgName.Text;
                this.lstPackages.SelectedItems[0].Text = this.txtPkgName.Text;
            }

        }

        private void btnBrowsePkg_Click(object sender, EventArgs e)
        {
            if (this.lstPackages.SelectedItems.Count <= 0)
            {
                return;
            }

            if (this.state != FormState.Ready)
            {
                return;
            }

            Package pkg = (Package)this.lstPackages.SelectedItems[0].Tag;

            string newPath = Utility.PickFolder();
            if (newPath != string.Empty)
            {
                pkg.Path = newPath;
            }

        }

        #endregion

    }
}
