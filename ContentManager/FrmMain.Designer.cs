namespace ContentManager
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBackupFolder = new System.Windows.Forms.Label();
            this.btnBackupDir = new System.Windows.Forms.Button();
            this.txtBackupDir = new System.Windows.Forms.TextBox();
            this.lblDbFile = new System.Windows.Forms.Label();
            this.btnBrowseStorage = new System.Windows.Forms.Button();
            this.txtStoragePath = new System.Windows.Forms.TextBox();
            this.lblGameRoot = new System.Windows.Forms.Label();
            this.lblStorage = new System.Windows.Forms.Label();
            this.btnBrowseGameRoot = new System.Windows.Forms.Button();
            this.btnBrowseDbFile = new System.Windows.Forms.Button();
            this.txtGameRoot = new System.Windows.Forms.TextBox();
            this.txtProjectRoot = new System.Windows.Forms.TextBox();
            this.tbcOperations = new System.Windows.Forms.TabControl();
            this.tbModDevFiles = new System.Windows.Forms.TabPage();
            this.tbContent = new System.Windows.Forms.TabPage();
            this.ctxCredits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPkgConflict = new System.Windows.Forms.TabPage();
            this.tbcOperations.SuspendLayout();
            this.ctxCredits.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBackupFolder
            // 
            this.lblBackupFolder.AutoSize = true;
            this.lblBackupFolder.Location = new System.Drawing.Point(21, 87);
            this.lblBackupFolder.Name = "lblBackupFolder";
            this.lblBackupFolder.Size = new System.Drawing.Size(58, 13);
            this.lblBackupFolder.TabIndex = 29;
            this.lblBackupFolder.Text = "Backup dir";
            // 
            // btnBackupDir
            // 
            this.btnBackupDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackupDir.Location = new System.Drawing.Point(1500, 84);
            this.btnBackupDir.Name = "btnBackupDir";
            this.btnBackupDir.Size = new System.Drawing.Size(54, 20);
            this.btnBackupDir.TabIndex = 28;
            this.btnBackupDir.Text = "...";
            this.btnBackupDir.UseVisualStyleBackColor = true;
            this.btnBackupDir.Click += new System.EventHandler(this.btnBackupDir_Click);
            // 
            // txtBackupDir
            // 
            this.txtBackupDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackupDir.Location = new System.Drawing.Point(85, 84);
            this.txtBackupDir.Name = "txtBackupDir";
            this.txtBackupDir.ReadOnly = true;
            this.txtBackupDir.Size = new System.Drawing.Size(1409, 20);
            this.txtBackupDir.TabIndex = 27;
            // 
            // lblDbFile
            // 
            this.lblDbFile.AutoSize = true;
            this.lblDbFile.Location = new System.Drawing.Point(18, 10);
            this.lblDbFile.Name = "lblDbFile";
            this.lblDbFile.Size = new System.Drawing.Size(61, 13);
            this.lblDbFile.TabIndex = 25;
            this.lblDbFile.Text = "Project root";
            // 
            // btnBrowseStorage
            // 
            this.btnBrowseStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseStorage.Location = new System.Drawing.Point(1500, 58);
            this.btnBrowseStorage.Name = "btnBrowseStorage";
            this.btnBrowseStorage.Size = new System.Drawing.Size(54, 20);
            this.btnBrowseStorage.TabIndex = 24;
            this.btnBrowseStorage.Text = "...";
            this.btnBrowseStorage.UseVisualStyleBackColor = true;
            this.btnBrowseStorage.Click += new System.EventHandler(this.btnBrowseStorage_Click);
            // 
            // txtStoragePath
            // 
            this.txtStoragePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStoragePath.Location = new System.Drawing.Point(85, 58);
            this.txtStoragePath.Name = "txtStoragePath";
            this.txtStoragePath.ReadOnly = true;
            this.txtStoragePath.Size = new System.Drawing.Size(1409, 20);
            this.txtStoragePath.TabIndex = 23;
            // 
            // lblGameRoot
            // 
            this.lblGameRoot.AutoSize = true;
            this.lblGameRoot.Location = new System.Drawing.Point(23, 36);
            this.lblGameRoot.Name = "lblGameRoot";
            this.lblGameRoot.Size = new System.Drawing.Size(56, 13);
            this.lblGameRoot.TabIndex = 22;
            this.lblGameRoot.Text = "Game root";
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Location = new System.Drawing.Point(35, 61);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(44, 13);
            this.lblStorage.TabIndex = 21;
            this.lblStorage.Text = "Storage";
            // 
            // btnBrowseGameRoot
            // 
            this.btnBrowseGameRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseGameRoot.Location = new System.Drawing.Point(1500, 32);
            this.btnBrowseGameRoot.Name = "btnBrowseGameRoot";
            this.btnBrowseGameRoot.Size = new System.Drawing.Size(54, 20);
            this.btnBrowseGameRoot.TabIndex = 20;
            this.btnBrowseGameRoot.Text = "...";
            this.btnBrowseGameRoot.UseVisualStyleBackColor = true;
            this.btnBrowseGameRoot.Click += new System.EventHandler(this.btnBrowseGameRoot_Click);
            // 
            // btnBrowseDbFile
            // 
            this.btnBrowseDbFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDbFile.Location = new System.Drawing.Point(1500, 6);
            this.btnBrowseDbFile.Name = "btnBrowseDbFile";
            this.btnBrowseDbFile.Size = new System.Drawing.Size(54, 20);
            this.btnBrowseDbFile.TabIndex = 19;
            this.btnBrowseDbFile.Text = "...";
            this.btnBrowseDbFile.UseVisualStyleBackColor = true;
            this.btnBrowseDbFile.Click += new System.EventHandler(this.btnBrowseDbFile_Click);
            // 
            // txtGameRoot
            // 
            this.txtGameRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameRoot.Location = new System.Drawing.Point(85, 32);
            this.txtGameRoot.Name = "txtGameRoot";
            this.txtGameRoot.ReadOnly = true;
            this.txtGameRoot.Size = new System.Drawing.Size(1409, 20);
            this.txtGameRoot.TabIndex = 18;
            // 
            // txtProjectRoot
            // 
            this.txtProjectRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectRoot.Location = new System.Drawing.Point(85, 6);
            this.txtProjectRoot.Name = "txtProjectRoot";
            this.txtProjectRoot.ReadOnly = true;
            this.txtProjectRoot.Size = new System.Drawing.Size(1409, 20);
            this.txtProjectRoot.TabIndex = 17;
            // 
            // tbcOperations
            // 
            this.tbcOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcOperations.Controls.Add(this.tbModDevFiles);
            this.tbcOperations.Controls.Add(this.tbContent);
            this.tbcOperations.Controls.Add(this.tbPkgConflict);
            this.tbcOperations.Location = new System.Drawing.Point(12, 110);
            this.tbcOperations.Name = "tbcOperations";
            this.tbcOperations.SelectedIndex = 0;
            this.tbcOperations.Size = new System.Drawing.Size(1542, 671);
            this.tbcOperations.TabIndex = 0;
            // 
            // tbModDevFiles
            // 
            this.tbModDevFiles.Location = new System.Drawing.Point(4, 22);
            this.tbModDevFiles.Name = "tbModDevFiles";
            this.tbModDevFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tbModDevFiles.Size = new System.Drawing.Size(1534, 645);
            this.tbModDevFiles.TabIndex = 2;
            this.tbModDevFiles.Text = "Mod development";
            this.tbModDevFiles.UseVisualStyleBackColor = true;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(4, 22);
            this.tbContent.Name = "tbContent";
            this.tbContent.Padding = new System.Windows.Forms.Padding(3);
            this.tbContent.Size = new System.Drawing.Size(1534, 645);
            this.tbContent.TabIndex = 0;
            this.tbContent.Text = "Community Packages";
            this.tbContent.UseVisualStyleBackColor = true;
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
            this.cmiAdd.Size = new System.Drawing.Size(117, 22);
            this.cmiAdd.Text = "Add";
            // 
            // cmiRemove
            // 
            this.cmiRemove.Name = "cmiRemove";
            this.cmiRemove.Size = new System.Drawing.Size(117, 22);
            this.cmiRemove.Text = "Remove";
            // 
            // tbPkgConflict
            // 
            this.tbPkgConflict.Location = new System.Drawing.Point(4, 22);
            this.tbPkgConflict.Name = "tbPkgConflict";
            this.tbPkgConflict.Padding = new System.Windows.Forms.Padding(3);
            this.tbPkgConflict.Size = new System.Drawing.Size(1534, 645);
            this.tbPkgConflict.TabIndex = 3;
            this.tbPkgConflict.Text = "Conflicts";
            this.tbPkgConflict.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 793);
            this.Controls.Add(this.tbcOperations);
            this.Controls.Add(this.lblBackupFolder);
            this.Controls.Add(this.btnBackupDir);
            this.Controls.Add(this.txtBackupDir);
            this.Controls.Add(this.lblDbFile);
            this.Controls.Add(this.btnBrowseStorage);
            this.Controls.Add(this.txtStoragePath);
            this.Controls.Add(this.lblGameRoot);
            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.btnBrowseGameRoot);
            this.Controls.Add(this.btnBrowseDbFile);
            this.Controls.Add(this.txtGameRoot);
            this.Controls.Add(this.txtProjectRoot);
            this.Name = "FrmMain";
            this.Text = "Content Manager";
            this.tbcOperations.ResumeLayout(false);
            this.ctxCredits.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackupFolder;
        private System.Windows.Forms.Button btnBackupDir;
        private System.Windows.Forms.TextBox txtBackupDir;
        private System.Windows.Forms.Label lblDbFile;
        private System.Windows.Forms.Button btnBrowseStorage;
        private System.Windows.Forms.TextBox txtStoragePath;
        private System.Windows.Forms.Label lblGameRoot;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Button btnBrowseGameRoot;
        private System.Windows.Forms.Button btnBrowseDbFile;
        private System.Windows.Forms.TextBox txtGameRoot;
        private System.Windows.Forms.TextBox txtProjectRoot;
        private System.Windows.Forms.TabControl tbcOperations;
        private System.Windows.Forms.TabPage tbContent;
        private System.Windows.Forms.ContextMenuStrip ctxCredits;
        private System.Windows.Forms.ToolStripMenuItem cmiAdd;
        private System.Windows.Forms.ToolStripMenuItem cmiRemove;
        private System.Windows.Forms.TabPage tbModDevFiles;
        private System.Windows.Forms.TabPage tbPkgConflict;
    }
}

