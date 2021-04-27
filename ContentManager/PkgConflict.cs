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

        private List<FileConflict> conflictCollection = new List<FileConflict>();
        
        #endregion

        #region Constructor

        public PkgConflict(Project prj)
        {
            this.project = prj;

            InitializeComponent();
        }

        #endregion

        #region Private methods


        private void setConflictOptionFields(FileConflict fileConflict)
        {

            this.rdbUnresolved.Checked = fileConflict.Solution == ConflictSolution.Unresolved;
            this.rdbUseThisPkg.Checked = fileConflict.Solution == ConflictSolution.Use_file_current_package;
            this.rdbOtherPkg.Checked = fileConflict.Solution == ConflictSolution.Use_file_from_pkg_specified;
            this.rdbDifferentPath.Checked = fileConflict.Solution == ConflictSolution.Use_custom_file;

            this.cmbFileOtherPkg.Items.Clear();
            this.cmbFileOtherPkg.Items.AddRange(
                fileConflict.Group.Select(x => x.Item2).ToArray()
                );



        }

        private void disableConflictOptionFields()
        {
            this.grpFileOp.Enabled = false;
        }

        private void enableConflictOptionFields()
        {
            this.grpFileOp.Enabled = true;
        }


        #endregion

        #region Events

        private void btnCheckPkg_Click(object sender, EventArgs e)
        {
            ConflictSearcher searcher = new ConflictSearcher(this.project);
            this.conflictCollection.Clear();
            this.conflictCollection = searcher.FindConflictsBetweenPkgs();

            this.trvConflicts.Nodes.Clear();

            foreach (var conflict in this.conflictCollection)
            {
                TreeNode node = new TreeNode("File: " + conflict.Group[0].Item2.RelPath);
                node.Tag = (object)conflict;

                node.Nodes.Add(new TreeNode("Conflicts in Gameroot"));

                foreach (var group in conflict.Group)
                {
                    node.Nodes.Add(new TreeNode("In package: " + group.Item1.Name));
                }

                this.trvConflicts.Nodes.Add(node);
            }

            if(this.conflictCollection.Count() > 0)
            {
                this.enableConflictOptionFields();
                this.setConflictOptionFields(this.conflictCollection[0]);
            } else
            {
                this.disableConflictOptionFields();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.project.UpdateConflicts(this.conflictCollection);
            this.project.Save();
        }

        #endregion

    }
}
