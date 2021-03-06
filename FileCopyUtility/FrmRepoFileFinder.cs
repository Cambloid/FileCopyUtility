﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopyUtility
{
    public partial class FrmRepoFileFinder : Form
    {
        #region Private vars

        private FileList list;

        #endregion

        #region Constructor

        public FrmRepoFileFinder(FileList list)
        {
            InitializeComponent();

            this.list = list;

            string repoPath = Properties.Settings.Default.PathRepo;
            string[] files = Directory.GetFiles(repoPath, "*.*", SearchOption.AllDirectories);


            foreach(string file in files )
            {
                string baseRelPath = FilePair.GetBaseRelativePath(file);

                bool isFileInList = list.CheckIfFileExistsInList(baseRelPath);

                // If file is not in the list then add show it later in the list view
                if(!isFileInList)
                {
                    this.listFiles.Items.Add(baseRelPath);
                }
            }
        }

        #endregion

        #region Events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in this.listFiles.Items)
            {
                if(item.Checked)
                {
                    this.list.Files.Add(item.SubItems[0].Text);
                }
            }

            this.list.SaveToFile(Properties.Settings.Default.PathFileList);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listFiles.Items)
            {
                item.Checked = true;
            }
        }

        #endregion
    }
}
