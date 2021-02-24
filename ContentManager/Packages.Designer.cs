
namespace ContentManager
{
    partial class Packages
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lstPackages = new System.Windows.Forms.ListView();
            this.colPackage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trvFiles = new System.Windows.Forms.TreeView();
            this.btnBrowsePkg = new System.Windows.Forms.Button();
            this.grpPkgStatus = new System.Windows.Forms.GroupBox();
            this.lblPackageHash = new System.Windows.Forms.Label();
            this.txtPackageHash = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPkgStatus = new System.Windows.Forms.TextBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lstCredits = new System.Windows.Forms.ListBox();
            this.lblPackageSize = new System.Windows.Forms.Label();
            this.txtPkgSize = new System.Windows.Forms.TextBox();
            this.lblPackagePath = new System.Windows.Forms.Label();
            this.txtPkgPath = new System.Windows.Forms.TextBox();
            this.lblPackageID = new System.Windows.Forms.Label();
            this.txtPkgId = new System.Windows.Forms.TextBox();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.ctxCredits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ctxCredits.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnBrowsePkg);
            this.splitContainer1.Panel2.Controls.Add(this.grpPkgStatus);
            this.splitContainer1.Panel2.Controls.Add(this.lblPackageHash);
            this.splitContainer1.Panel2.Controls.Add(this.txtPackageHash);
            this.splitContainer1.Panel2.Controls.Add(this.lblStatus);
            this.splitContainer1.Panel2.Controls.Add(this.txtPkgStatus);
            this.splitContainer1.Panel2.Controls.Add(this.lblCredits);
            this.splitContainer1.Panel2.Controls.Add(this.lstCredits);
            this.splitContainer1.Panel2.Controls.Add(this.lblPackageSize);
            this.splitContainer1.Panel2.Controls.Add(this.txtPkgSize);
            this.splitContainer1.Panel2.Controls.Add(this.lblPackagePath);
            this.splitContainer1.Panel2.Controls.Add(this.txtPkgPath);
            this.splitContainer1.Panel2.Controls.Add(this.lblPackageID);
            this.splitContainer1.Panel2.Controls.Add(this.txtPkgId);
            this.splitContainer1.Panel2.Controls.Add(this.lblPackageName);
            this.splitContainer1.Panel2.Controls.Add(this.txtPkgName);
            this.splitContainer1.Size = new System.Drawing.Size(1403, 839);
            this.splitContainer1.SplitterDistance = 516;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstPackages);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.trvFiles);
            this.splitContainer2.Size = new System.Drawing.Size(516, 839);
            this.splitContainer2.SplitterDistance = 220;
            this.splitContainer2.TabIndex = 0;
            // 
            // lstPackages
            // 
            this.lstPackages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPackage});
            this.lstPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPackages.FullRowSelect = true;
            this.lstPackages.GridLines = true;
            this.lstPackages.HideSelection = false;
            this.lstPackages.Location = new System.Drawing.Point(0, 0);
            this.lstPackages.Name = "lstPackages";
            this.lstPackages.Size = new System.Drawing.Size(220, 839);
            this.lstPackages.TabIndex = 33;
            this.lstPackages.UseCompatibleStateImageBehavior = false;
            this.lstPackages.View = System.Windows.Forms.View.Details;
            this.lstPackages.SelectedIndexChanged += new System.EventHandler(this.lstPackages_SelectedIndexChanged);
            // 
            // colPackage
            // 
            this.colPackage.Text = "Package";
            this.colPackage.Width = 204;
            // 
            // trvFiles
            // 
            this.trvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvFiles.Location = new System.Drawing.Point(0, 0);
            this.trvFiles.Name = "trvFiles";
            this.trvFiles.Size = new System.Drawing.Size(292, 839);
            this.trvFiles.TabIndex = 34;
            // 
            // btnBrowsePkg
            // 
            this.btnBrowsePkg.Location = new System.Drawing.Point(527, 22);
            this.btnBrowsePkg.Name = "btnBrowsePkg";
            this.btnBrowsePkg.Size = new System.Drawing.Size(36, 20);
            this.btnBrowsePkg.TabIndex = 61;
            this.btnBrowsePkg.Text = "...";
            this.btnBrowsePkg.UseVisualStyleBackColor = true;
            this.btnBrowsePkg.Click += new System.EventHandler(this.btnBrowsePkg_Click);
            // 
            // grpPkgStatus
            // 
            this.grpPkgStatus.Location = new System.Drawing.Point(569, 22);
            this.grpPkgStatus.Name = "grpPkgStatus";
            this.grpPkgStatus.Size = new System.Drawing.Size(311, 100);
            this.grpPkgStatus.TabIndex = 70;
            this.grpPkgStatus.TabStop = false;
            this.grpPkgStatus.Text = "Package status";
            // 
            // lblPackageHash
            // 
            this.lblPackageHash.AutoSize = true;
            this.lblPackageHash.Location = new System.Drawing.Point(19, 77);
            this.lblPackageHash.Name = "lblPackageHash";
            this.lblPackageHash.Size = new System.Drawing.Size(79, 13);
            this.lblPackageHash.TabIndex = 69;
            this.lblPackageHash.Text = "Package hash:";
            // 
            // txtPackageHash
            // 
            this.txtPackageHash.Location = new System.Drawing.Point(107, 74);
            this.txtPackageHash.Name = "txtPackageHash";
            this.txtPackageHash.ReadOnly = true;
            this.txtPackageHash.Size = new System.Drawing.Size(456, 20);
            this.txtPackageHash.TabIndex = 68;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(373, 103);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 13);
            this.lblStatus.TabIndex = 67;
            this.lblStatus.Text = "Package status:";
            // 
            // txtPkgStatus
            // 
            this.txtPkgStatus.Location = new System.Drawing.Point(463, 100);
            this.txtPkgStatus.Name = "txtPkgStatus";
            this.txtPkgStatus.ReadOnly = true;
            this.txtPkgStatus.Size = new System.Drawing.Size(100, 20);
            this.txtPkgStatus.TabIndex = 66;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(14, 127);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(87, 13);
            this.lblCredits.TabIndex = 65;
            this.lblCredits.Text = "Package credits:";
            // 
            // lstCredits
            // 
            this.lstCredits.FormattingEnabled = true;
            this.lstCredits.Location = new System.Drawing.Point(107, 127);
            this.lstCredits.Name = "lstCredits";
            this.lstCredits.Size = new System.Drawing.Size(277, 186);
            this.lstCredits.TabIndex = 64;
            // 
            // lblPackageSize
            // 
            this.lblPackageSize.AutoSize = true;
            this.lblPackageSize.Location = new System.Drawing.Point(27, 103);
            this.lblPackageSize.Name = "lblPackageSize";
            this.lblPackageSize.Size = new System.Drawing.Size(74, 13);
            this.lblPackageSize.TabIndex = 63;
            this.lblPackageSize.Text = "Package size:";
            // 
            // txtPkgSize
            // 
            this.txtPkgSize.Location = new System.Drawing.Point(107, 100);
            this.txtPkgSize.Name = "txtPkgSize";
            this.txtPkgSize.ReadOnly = true;
            this.txtPkgSize.Size = new System.Drawing.Size(102, 20);
            this.txtPkgSize.TabIndex = 62;
            // 
            // lblPackagePath
            // 
            this.lblPackagePath.AutoSize = true;
            this.lblPackagePath.Location = new System.Drawing.Point(24, 25);
            this.lblPackagePath.Name = "lblPackagePath";
            this.lblPackagePath.Size = new System.Drawing.Size(77, 13);
            this.lblPackagePath.TabIndex = 60;
            this.lblPackagePath.Text = "Package path:";
            // 
            // txtPkgPath
            // 
            this.txtPkgPath.Location = new System.Drawing.Point(107, 22);
            this.txtPkgPath.Name = "txtPkgPath";
            this.txtPkgPath.ReadOnly = true;
            this.txtPkgPath.Size = new System.Drawing.Size(414, 20);
            this.txtPkgPath.TabIndex = 59;
            // 
            // lblPackageID
            // 
            this.lblPackageID.AutoSize = true;
            this.lblPackageID.Location = new System.Drawing.Point(390, 51);
            this.lblPackageID.Name = "lblPackageID";
            this.lblPackageID.Size = new System.Drawing.Size(67, 13);
            this.lblPackageID.TabIndex = 58;
            this.lblPackageID.Text = "Package ID:";
            // 
            // txtPkgId
            // 
            this.txtPkgId.Location = new System.Drawing.Point(463, 48);
            this.txtPkgId.Name = "txtPkgId";
            this.txtPkgId.ReadOnly = true;
            this.txtPkgId.Size = new System.Drawing.Size(100, 20);
            this.txtPkgId.TabIndex = 57;
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Location = new System.Drawing.Point(19, 51);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(82, 13);
            this.lblPackageName.TabIndex = 56;
            this.lblPackageName.Text = "Package name:";
            // 
            // txtPkgName
            // 
            this.txtPkgName.Location = new System.Drawing.Point(107, 48);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(277, 20);
            this.txtPkgName.TabIndex = 55;
            this.txtPkgName.TextChanged += new System.EventHandler(this.txtPkgName_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 839);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1403, 31);
            this.panel2.TabIndex = 45;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(71, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(62, 24);
            this.btnRemove.TabIndex = 42;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(3, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(62, 24);
            this.btnImport.TabIndex = 41;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ctxCredits
            // 
            this.ctxCredits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiAdd,
            this.cmiRemove});
            this.ctxCredits.Name = "ctxCredits";
            this.ctxCredits.Size = new System.Drawing.Size(118, 48);
            // 
            // cmiAdd
            // 
            this.cmiAdd.Name = "cmiAdd";
            this.cmiAdd.Size = new System.Drawing.Size(180, 22);
            this.cmiAdd.Text = "Add";
            this.cmiAdd.Click += new System.EventHandler(this.cmiAdd_Click);
            // 
            // cmiRemove
            // 
            this.cmiRemove.Name = "cmiRemove";
            this.cmiRemove.Size = new System.Drawing.Size(180, 22);
            this.cmiRemove.Text = "Remove";
            this.cmiRemove.Click += new System.EventHandler(this.cmiRemove_Click);
            // 
            // Packages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Name = "Packages";
            this.Size = new System.Drawing.Size(1403, 870);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ctxCredits.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ListView lstPackages;
        private System.Windows.Forms.ColumnHeader colPackage;
        private System.Windows.Forms.TreeView trvFiles;
        private System.Windows.Forms.Button btnBrowsePkg;
        private System.Windows.Forms.GroupBox grpPkgStatus;
        private System.Windows.Forms.Label lblPackageHash;
        private System.Windows.Forms.TextBox txtPackageHash;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtPkgStatus;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.ListBox lstCredits;
        private System.Windows.Forms.Label lblPackageSize;
        private System.Windows.Forms.TextBox txtPkgSize;
        private System.Windows.Forms.Label lblPackagePath;
        private System.Windows.Forms.TextBox txtPkgPath;
        private System.Windows.Forms.Label lblPackageID;
        private System.Windows.Forms.TextBox txtPkgId;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.ContextMenuStrip ctxCredits;
        private System.Windows.Forms.ToolStripMenuItem cmiAdd;
        private System.Windows.Forms.ToolStripMenuItem cmiRemove;
    }
}
