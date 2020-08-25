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

        private Dictionary<string, byte[]> PackageFileHashes;

        #endregion

        #region Construktor

        public FrmMain()
        {
            InitializeComponent();
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
            if (this.state == FormState.Ready)
            {
                using (FrmInput input = new FrmInput())
                {
                    DialogResult res = input.ShowDialog(this);
                    if (res == DialogResult.Yes && input.Input != string.Empty)
                    {
                        // TODO: Create new package


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

        #endregion

    }
}
