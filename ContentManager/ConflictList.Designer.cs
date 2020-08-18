namespace ContentManager
{
    partial class ConflictList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPkgName = new System.Windows.Forms.Label();
            this.trvConflictFiles = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(3, 11);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(76, 13);
            this.lblPkgName.TabIndex = 40;
            this.lblPkgName.Text = "Packagename";
            // 
            // trvConflictFiles
            // 
            this.trvConflictFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trvConflictFiles.Location = new System.Drawing.Point(0, 41);
            this.trvConflictFiles.Name = "trvConflictFiles";
            this.trvConflictFiles.Size = new System.Drawing.Size(516, 523);
            this.trvConflictFiles.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 564);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 57);
            this.panel1.TabIndex = 41;
            // 
            // ConflictList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPkgName);
            this.Controls.Add(this.trvConflictFiles);
            this.Controls.Add(this.panel1);
            this.Name = "ConflictList";
            this.Size = new System.Drawing.Size(516, 621);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.TreeView trvConflictFiles;
        private System.Windows.Forms.Panel panel1;
    }
}
