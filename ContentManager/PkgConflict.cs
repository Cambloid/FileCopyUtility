using ContentManager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentManager
{
    public partial class PkgConflict : UserControl
    {

        #region Private vars

        private Project project;

        #endregion

        #region Constructor

        public PkgConflict(Project prj)
        {
            this.project = prj;

            InitializeComponent();
        }

        #endregion

        #region Events

        private void btnCheckPkg_Click(object sender, EventArgs e)
        {
            ConflictSearcher searcher = new ConflictSearcher(this.project);
            var conflicts = searcher.FindConflicts();

            this.trvConflicts.Nodes.Clear();
            foreach (var conflict in conflicts)
            {
                TreeNode node = new TreeNode("File: " + conflict.Group[0].Item2.RelPath);
                foreach (var group in conflict.Group)
                {
                    node.Nodes.Add(new TreeNode("In package: " + group.Item1.Name));
                }
                this.trvConflicts.Nodes.Add(node);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.project.Save();
        }

        #endregion

    }
}
