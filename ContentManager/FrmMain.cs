using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            // Load database or create if it doesnt exist
            this.db = new LiteDatabase("./Package.db");

            // Load all packages from db
            this.loadPackages();

        }

        #endregion

        #region Private methods

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

            var results = col.Query().Where(x => x.PackageId == pkg.Id).OrderBy(x => x.RelPath).ToList();

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
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                DialogResult res = dlg.ShowDialog(this);
                if(res == DialogResult.OK)
                {
                    this.txtProjectFile.Text = dlg.FileName;
                }
            }
        }

        private void btnBrowsePrjFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                DialogResult res = dlg.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    this.txtProjectFile.Text = dlg.FileName;
                }
            }
        }

        private void btnBrowseGameRoot_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                DialogResult res = dlg.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    this.txtGameRoot.Text = dlg.SelectedPath;
                }
            }
        }

        private void btnBrowseStorage_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                DialogResult res = dlg.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    this.txtStoragePath.Text = dlg.SelectedPath;
                }
            }
        }

        private void btnBackupDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                DialogResult res = dlg.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    this.txtBackupDir.Text = dlg.SelectedPath;
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (this.state == FormState.Ready || true /*tmp*/)
            {
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
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (this.state == FormState.Ready)
            {

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
            if (sender == null)
            {
                return;
            }

            ListViewItem item = (ListViewItem)sender;

            if(item != null)
            {
                this.loadFilesBySelectedPackage((Package)item.Tag);
            }

        }


        #endregion

    }
}
