using Base;
using ContentManager.Data;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentManager
{
    public partial class Packages : UserControl
    {
        #region Private vars

        private enum FormState
        {
            Ready,
            NotReady
        }

        private FormState state = FormState.NotReady;

        private Project project;

        private bool listSelectionChanging = false;

        #endregion

        #region Constructor

        public Packages(Project project)
        {
            InitializeComponent();

            this.project = project;
            this.btnSave.Enabled = false;
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
            this.btnImport.Enabled = this.state == FormState.Ready;
            this.btnRemove.Enabled = this.state == FormState.Ready;

            // Pkg info
            this.lstPackages.Enabled = this.state == FormState.Ready;
            this.lstFiles.Enabled = this.state == FormState.Ready;
            this.txtPkgPath.Enabled = this.state == FormState.Ready;
            this.txtPkgName.Enabled = this.state == FormState.Ready;
            this.btnBrowsePkg.Enabled = this.state == FormState.Ready;
            this.lstCredits.Enabled = this.state == FormState.Ready;


        }

        private void fillListPackages()
        {

            if (this.state != FormState.Ready)
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

        private void removePackageById(int packageId)
        {
            this.project.RemovePkg(packageId);

            this.btnSave.Enabled = true;
        }

        private void selectFirstPackage()
        {
            if (this.lstPackages.Items.Count <= 0)
            {
                this.lstFiles.Items.Clear();
            }
            else
            {
                Package pkg = (Package)this.lstPackages.Items[0].Tag;
                this.setFieldsBySelectedPackage(pkg);
            }
        }

        private void setFieldsBySelectedPackage(Package pkg)
        {
            this.txtPkgPath.Text = pkg.Path;
            if (Directory.Exists(pkg.Path))
            {
                this.txtPkgPath.BackColor = Color.White;
            }
            else
            {
                this.txtPkgPath.BackColor = Color.Red;
            }

            this.txtPkgName.Text = pkg.Name;
            this.txtPkgId.Text = pkg.PkgId.ToString();
            this.txtPkgSize.Text = pkg.ByteSize.ToString() + " Bytes";

            this.lstCredits.Items.Clear();
            foreach (string credit in pkg.Credits)
            {
                this.lstCredits.Items.Add(credit);
            }



            this.lstFiles.Items.Clear();

            TreeNode lastNode = null;
            string subPathAdd = string.Empty;

            foreach (PackageFile file in pkg.FileCollection.OrderBy(x => x.RelPath))
            {
                var item = new ListViewItem(file.RelPath);
                item.Tag = file;
                this.lstFiles.Items.Add(item);
            }

            this.txtPkgStatus.Text =
                pkg.Status == Package.PackageStatus.Installed ? "Installed" : "Not Installed";
        }

        private void setFileFields(PackageFile file)
        {
            this.txtFileHash.Text     = string.Empty;
            this.txtRelPath.Text      = string.Empty;
            this.txtFileName.Text     = string.Empty;
            this.chkDoNotCopy.Checked = false;

            if (file == null)
            {
                return;
            }

            this.txtFileHash.Text = file.Sha256;
            this.txtRelPath.Text = file.RelPath;
            this.txtFileName.Text = file.Name;
            this.chkDoNotCopy.Checked = file.DoNotCopy;
            

        }
       
        private void updateFormState()
        {

            // TODO: Check formstate
            this.state = FormState.Ready;

        }

        #endregion

        #region Events

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (this.state != FormState.Ready)
            {
                return;
            }

            string folder = Utility.PickFolder();
            if (folder == string.Empty)
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
                this.fillListPackages();
                this.selectFirstPackage();

                this.btnSave.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.state == FormState.Ready)
            {
                if (this.lstPackages.SelectedItems.Count > 0)
                {
                    try
                    {
                        Package pkg = (Package)this.lstPackages.SelectedItems[0].Tag;

                        //this.removeFilesByPackageId(pkg.PkgId);

                        this.removePackageById(pkg.PkgId);

                        this.fillListPackages();

                        this.selectFirstPackage();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }


                }


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

        private void lstPackages_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.listSelectionChanging = true;

            if (this.lstPackages.SelectedItems.Count <= 0)
            {
                return;
            }
            ListViewItem item = (ListViewItem)this.lstPackages.SelectedItems[0];
            if (item != null)
            {
                this.setFieldsBySelectedPackage((Package)item.Tag);
            }


            this.listSelectionChanging = false;
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

        private void txtPkgName_TextChanged(object sender, EventArgs e)
        {

            if (this.lstPackages.SelectedItems.Count <= 0 || 
                this.state != FormState.Ready || 
                listSelectionChanging)
            {
                return;
            }

            Package pkg = (Package)this.lstPackages.SelectedItems[0].Tag;
            if (this.txtPkgName.Text != string.Empty)
            {
                pkg.Name = this.txtPkgName.Text;
                this.lstPackages.SelectedItems[0].Text = this.txtPkgName.Text;

                this.btnSave.Enabled = true;
            }
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listSelectionChanging = true;

            if (this.lstFiles.SelectedItems.Count > 0)
            {
                this.setFileFields((PackageFile)this.lstFiles.SelectedItems[0].Tag);
            }

            this.listSelectionChanging = false;
        }

        private void chkDoNotCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lstFiles.SelectedItems.Count > 0  && !listSelectionChanging)
            {
                var file = (PackageFile)this.lstFiles.SelectedItems[0].Tag;
                file.DoNotCopy = this.chkDoNotCopy.Checked;
                this.btnSave.Enabled = true;
            }
        }

        private void Packages_Load(object sender, EventArgs e)
        {
            this.updateFormState();

            this.fillListPackages();
            this.selectFirstPackage();
            this.setFieldsByStatus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.project.Save();
            this.btnSave.Enabled = false;
        }

        private void btnCheckPkgStatus_Click(object sender, EventArgs e)
        {

            // Check if package is installed
            // A package is installed when:
            // - all the files which can be copied (except files with DoNotCopy flag set) exist in the gameroot dir
            // - Files from the package and in the gameroot dir have the same hash value

            if (this.lstPackages.SelectedItems.Count > 0)
            {
                Package selectedPkg = (Package)this.lstPackages.SelectedItems[0].Tag;
                if (selectedPkg != null)
                {
                    // Check files

                    PackageHandler handler = new PackageHandler(this.project);
                    handler.CheckStatusAndUpdate(selectedPkg);

                }

            }

        }

        #endregion

    }
}
