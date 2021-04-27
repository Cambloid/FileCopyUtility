
namespace ContentManager
{
    partial class PkgConflict
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckPkg = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grpAutomatic = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.grpFileOp = new System.Windows.Forms.GroupBox();
            this.rdbDifferentPath = new System.Windows.Forms.RadioButton();
            this.btnFileOtherPath = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.rdbOtherPkg = new System.Windows.Forms.RadioButton();
            this.rdbUseThisPkg = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvConflicts = new System.Windows.Forms.TreeView();
            this.rdbUnresolved = new System.Windows.Forms.RadioButton();
            this.cmbFileOtherPkg = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.grpAutomatic.SuspendLayout();
            this.grpFileOp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.btnCheckPkg);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 792);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1559, 29);
            this.panel1.TabIndex = 60;
            // 
            // btnCheckPkg
            // 
            this.btnCheckPkg.Location = new System.Drawing.Point(7, 3);
            this.btnCheckPkg.Name = "btnCheckPkg";
            this.btnCheckPkg.Size = new System.Drawing.Size(182, 23);
            this.btnCheckPkg.TabIndex = 59;
            this.btnCheckPkg.Text = "Check packages for conflicts";
            this.btnCheckPkg.UseVisualStyleBackColor = true;
            this.btnCheckPkg.Click += new System.EventHandler(this.btnCheckPkg_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1342, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(214, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 23);
            this.button3.TabIndex = 58;
            this.button3.Text = "Apply state from root folder";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // grpAutomatic
            // 
            this.grpAutomatic.Controls.Add(this.button3);
            this.grpAutomatic.Location = new System.Drawing.Point(7, 187);
            this.grpAutomatic.Name = "grpAutomatic";
            this.grpAutomatic.Size = new System.Drawing.Size(444, 206);
            this.grpAutomatic.TabIndex = 66;
            this.grpAutomatic.TabStop = false;
            this.grpAutomatic.Text = "Automatic";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 21);
            this.button1.TabIndex = 65;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 63;
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(30, 151);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 21);
            this.comboBox2.TabIndex = 64;
            // 
            // grpFileOp
            // 
            this.grpFileOp.Controls.Add(this.cmbFileOtherPkg);
            this.grpFileOp.Controls.Add(this.rdbUnresolved);
            this.grpFileOp.Controls.Add(this.rdbDifferentPath);
            this.grpFileOp.Controls.Add(this.btnFileOtherPath);
            this.grpFileOp.Controls.Add(this.btnSelectFile);
            this.grpFileOp.Controls.Add(this.rdbOtherPkg);
            this.grpFileOp.Controls.Add(this.rdbUseThisPkg);
            this.grpFileOp.Location = new System.Drawing.Point(7, 10);
            this.grpFileOp.Name = "grpFileOp";
            this.grpFileOp.Size = new System.Drawing.Size(444, 128);
            this.grpFileOp.TabIndex = 62;
            this.grpFileOp.TabStop = false;
            this.grpFileOp.Text = "Use file from ...";
            // 
            // rdbDifferentPath
            // 
            this.rdbDifferentPath.AutoSize = true;
            this.rdbDifferentPath.Location = new System.Drawing.Point(13, 90);
            this.rdbDifferentPath.Name = "rdbDifferentPath";
            this.rdbDifferentPath.Size = new System.Drawing.Size(87, 17);
            this.rdbDifferentPath.TabIndex = 58;
            this.rdbDifferentPath.TabStop = true;
            this.rdbDifferentPath.Text = "different path";
            this.rdbDifferentPath.UseVisualStyleBackColor = true;
            // 
            // btnFileOtherPath
            // 
            this.btnFileOtherPath.Location = new System.Drawing.Point(148, 88);
            this.btnFileOtherPath.Name = "btnFileOtherPath";
            this.btnFileOtherPath.Size = new System.Drawing.Size(244, 21);
            this.btnFileOtherPath.TabIndex = 57;
            this.btnFileOtherPath.Text = "Add file from root to new pkg";
            this.btnFileOtherPath.UseVisualStyleBackColor = true;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(397, 65);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(40, 21);
            this.btnSelectFile.TabIndex = 56;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // rdbOtherPkg
            // 
            this.rdbOtherPkg.AutoSize = true;
            this.rdbOtherPkg.Location = new System.Drawing.Point(13, 67);
            this.rdbOtherPkg.Name = "rdbOtherPkg";
            this.rdbOtherPkg.Size = new System.Drawing.Size(94, 17);
            this.rdbOtherPkg.TabIndex = 53;
            this.rdbOtherPkg.TabStop = true;
            this.rdbOtherPkg.Text = "other package";
            this.rdbOtherPkg.UseVisualStyleBackColor = true;
            // 
            // rdbUseThisPkg
            // 
            this.rdbUseThisPkg.AutoSize = true;
            this.rdbUseThisPkg.Location = new System.Drawing.Point(13, 44);
            this.rdbUseThisPkg.Name = "rdbUseThisPkg";
            this.rdbUseThisPkg.Size = new System.Drawing.Size(86, 17);
            this.rdbUseThisPkg.TabIndex = 52;
            this.rdbUseThisPkg.TabStop = true;
            this.rdbUseThisPkg.Text = "this package";
            this.rdbUseThisPkg.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvConflicts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.grpFileOp);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel2.Controls.Add(this.grpAutomatic);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(1559, 792);
            this.splitContainer1.SplitterDistance = 521;
            this.splitContainer1.TabIndex = 67;
            // 
            // trvConflicts
            // 
            this.trvConflicts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvConflicts.FullRowSelect = true;
            this.trvConflicts.Location = new System.Drawing.Point(0, 0);
            this.trvConflicts.Name = "trvConflicts";
            this.trvConflicts.Size = new System.Drawing.Size(521, 792);
            this.trvConflicts.TabIndex = 62;
            // 
            // rdbUnresolved
            // 
            this.rdbUnresolved.AutoSize = true;
            this.rdbUnresolved.Location = new System.Drawing.Point(13, 21);
            this.rdbUnresolved.Name = "rdbUnresolved";
            this.rdbUnresolved.Size = new System.Drawing.Size(79, 17);
            this.rdbUnresolved.TabIndex = 59;
            this.rdbUnresolved.TabStop = true;
            this.rdbUnresolved.Text = "Unresolved";
            this.rdbUnresolved.UseVisualStyleBackColor = true;
            // 
            // cmbFileOtherPkg
            // 
            this.cmbFileOtherPkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFileOtherPkg.FormattingEnabled = true;
            this.cmbFileOtherPkg.Location = new System.Drawing.Point(148, 65);
            this.cmbFileOtherPkg.Name = "cmbFileOtherPkg";
            this.cmbFileOtherPkg.Size = new System.Drawing.Size(244, 21);
            this.cmbFileOtherPkg.TabIndex = 67;
            // 
            // PkgConflict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "PkgConflict";
            this.Size = new System.Drawing.Size(1559, 821);
            this.panel1.ResumeLayout(false);
            this.grpAutomatic.ResumeLayout(false);
            this.grpFileOp.ResumeLayout(false);
            this.grpFileOp.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckPkg;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox grpAutomatic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox grpFileOp;
        private System.Windows.Forms.RadioButton rdbDifferentPath;
        private System.Windows.Forms.Button btnFileOtherPath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.RadioButton rdbOtherPkg;
        private System.Windows.Forms.RadioButton rdbUseThisPkg;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvConflicts;
        private System.Windows.Forms.RadioButton rdbUnresolved;
        private System.Windows.Forms.ComboBox cmbFileOtherPkg;
    }
}
