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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("PkgMapTemplate");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("PkgCustomPerk1");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("FileXY.gdt", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.lblBackupFolder = new System.Windows.Forms.Label();
            this.btnBackupDir = new System.Windows.Forms.Button();
            this.txtBackupDir = new System.Windows.Forms.TextBox();
            this.btnNewFileList = new System.Windows.Forms.Button();
            this.lblFileListFile = new System.Windows.Forms.Label();
            this.btnBrowseFileList = new System.Windows.Forms.Button();
            this.txtFileList = new System.Windows.Forms.TextBox();
            this.lblGameRoot = new System.Windows.Forms.Label();
            this.lblRepo = new System.Windows.Forms.Label();
            this.btnBrowseGameRoot = new System.Windows.Forms.Button();
            this.btnBrowseRepo = new System.Windows.Forms.Button();
            this.txtGameRoot = new System.Windows.Forms.TextBox();
            this.txtPathRepo = new System.Windows.Forms.TextBox();
            this.tbcOperations = new System.Windows.Forms.TabControl();
            this.tbContent = new System.Windows.Forms.TabPage();
            this.lblPackagePath = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblPackageID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trvFiles = new System.Windows.Forms.TreeView();
            this.listFiles = new System.Windows.Forms.ListView();
            this.colPackage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbConflicts = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trvConflicts = new System.Windows.Forms.TreeView();
            this.tbcOperations.SuspendLayout();
            this.tbContent.SuspendLayout();
            this.tbConflicts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBackupFolder
            // 
            this.lblBackupFolder.AutoSize = true;
            this.lblBackupFolder.Location = new System.Drawing.Point(12, 87);
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
            // 
            // txtBackupDir
            // 
            this.txtBackupDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackupDir.Location = new System.Drawing.Point(72, 84);
            this.txtBackupDir.Name = "txtBackupDir";
            this.txtBackupDir.ReadOnly = true;
            this.txtBackupDir.Size = new System.Drawing.Size(1422, 20);
            this.txtBackupDir.TabIndex = 27;
            // 
            // btnNewFileList
            // 
            this.btnNewFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewFileList.Location = new System.Drawing.Point(1465, 58);
            this.btnNewFileList.Name = "btnNewFileList";
            this.btnNewFileList.Size = new System.Drawing.Size(29, 20);
            this.btnNewFileList.TabIndex = 26;
            this.btnNewFileList.Text = "+";
            this.btnNewFileList.UseVisualStyleBackColor = true;
            // 
            // lblFileListFile
            // 
            this.lblFileListFile.AutoSize = true;
            this.lblFileListFile.Location = new System.Drawing.Point(12, 60);
            this.lblFileListFile.Name = "lblFileListFile";
            this.lblFileListFile.Size = new System.Drawing.Size(38, 13);
            this.lblFileListFile.TabIndex = 25;
            this.lblFileListFile.Text = "File list";
            // 
            // btnBrowseFileList
            // 
            this.btnBrowseFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFileList.Location = new System.Drawing.Point(1500, 58);
            this.btnBrowseFileList.Name = "btnBrowseFileList";
            this.btnBrowseFileList.Size = new System.Drawing.Size(54, 20);
            this.btnBrowseFileList.TabIndex = 24;
            this.btnBrowseFileList.Text = "...";
            this.btnBrowseFileList.UseVisualStyleBackColor = true;
            // 
            // txtFileList
            // 
            this.txtFileList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileList.Location = new System.Drawing.Point(72, 58);
            this.txtFileList.Name = "txtFileList";
            this.txtFileList.ReadOnly = true;
            this.txtFileList.Size = new System.Drawing.Size(1387, 20);
            this.txtFileList.TabIndex = 23;
            // 
            // lblGameRoot
            // 
            this.lblGameRoot.AutoSize = true;
            this.lblGameRoot.Location = new System.Drawing.Point(12, 34);
            this.lblGameRoot.Name = "lblGameRoot";
            this.lblGameRoot.Size = new System.Drawing.Size(56, 13);
            this.lblGameRoot.TabIndex = 22;
            this.lblGameRoot.Text = "Game root";
            // 
            // lblRepo
            // 
            this.lblRepo.AutoSize = true;
            this.lblRepo.Location = new System.Drawing.Point(12, 9);
            this.lblRepo.Name = "lblRepo";
            this.lblRepo.Size = new System.Drawing.Size(57, 13);
            this.lblRepo.TabIndex = 21;
            this.lblRepo.Text = "Repository";
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
            // 
            // btnBrowseRepo
            // 
            this.btnBrowseRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseRepo.Location = new System.Drawing.Point(1500, 6);
            this.btnBrowseRepo.Name = "btnBrowseRepo";
            this.btnBrowseRepo.Size = new System.Drawing.Size(54, 20);
            this.btnBrowseRepo.TabIndex = 19;
            this.btnBrowseRepo.Text = "...";
            this.btnBrowseRepo.UseVisualStyleBackColor = true;
            // 
            // txtGameRoot
            // 
            this.txtGameRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameRoot.Location = new System.Drawing.Point(72, 32);
            this.txtGameRoot.Name = "txtGameRoot";
            this.txtGameRoot.ReadOnly = true;
            this.txtGameRoot.Size = new System.Drawing.Size(1422, 20);
            this.txtGameRoot.TabIndex = 18;
            // 
            // txtPathRepo
            // 
            this.txtPathRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathRepo.Location = new System.Drawing.Point(72, 6);
            this.txtPathRepo.Name = "txtPathRepo";
            this.txtPathRepo.ReadOnly = true;
            this.txtPathRepo.Size = new System.Drawing.Size(1422, 20);
            this.txtPathRepo.TabIndex = 17;
            // 
            // tbcOperations
            // 
            this.tbcOperations.Controls.Add(this.tbContent);
            this.tbcOperations.Controls.Add(this.tbConflicts);
            this.tbcOperations.Location = new System.Drawing.Point(12, 110);
            this.tbcOperations.Name = "tbcOperations";
            this.tbcOperations.SelectedIndex = 0;
            this.tbcOperations.Size = new System.Drawing.Size(1542, 656);
            this.tbcOperations.TabIndex = 32;
            // 
            // tbContent
            // 
            this.tbContent.Controls.Add(this.button2);
            this.tbContent.Controls.Add(this.button1);
            this.tbContent.Controls.Add(this.lblPackagePath);
            this.tbContent.Controls.Add(this.textBox3);
            this.tbContent.Controls.Add(this.lblPackageID);
            this.tbContent.Controls.Add(this.textBox2);
            this.tbContent.Controls.Add(this.btnSave);
            this.tbContent.Controls.Add(this.lblPackageName);
            this.tbContent.Controls.Add(this.textBox1);
            this.tbContent.Controls.Add(this.trvFiles);
            this.tbContent.Controls.Add(this.listFiles);
            this.tbContent.Location = new System.Drawing.Point(4, 22);
            this.tbContent.Name = "tbContent";
            this.tbContent.Padding = new System.Windows.Forms.Padding(3);
            this.tbContent.Size = new System.Drawing.Size(1534, 630);
            this.tbContent.TabIndex = 0;
            this.tbContent.Text = "Content";
            this.tbContent.UseVisualStyleBackColor = true;
            // 
            // lblPackagePath
            // 
            this.lblPackagePath.AutoSize = true;
            this.lblPackagePath.Location = new System.Drawing.Point(761, 82);
            this.lblPackagePath.Name = "lblPackagePath";
            this.lblPackagePath.Size = new System.Drawing.Size(77, 13);
            this.lblPackagePath.TabIndex = 40;
            this.lblPackagePath.Text = "Package path:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(844, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(634, 20);
            this.textBox3.TabIndex = 39;
            // 
            // lblPackageID
            // 
            this.lblPackageID.AutoSize = true;
            this.lblPackageID.Location = new System.Drawing.Point(972, 56);
            this.lblPackageID.Name = "lblPackageID";
            this.lblPackageID.Size = new System.Drawing.Size(67, 13);
            this.lblPackageID.TabIndex = 38;
            this.lblPackageID.Text = "Package ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1045, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 37;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1453, 601);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Location = new System.Drawing.Point(756, 56);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(82, 13);
            this.lblPackageName.TabIndex = 35;
            this.lblPackageName.Text = "Package name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(844, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 34;
            // 
            // trvFiles
            // 
            this.trvFiles.Location = new System.Drawing.Point(318, 0);
            this.trvFiles.Name = "trvFiles";
            this.trvFiles.Size = new System.Drawing.Size(417, 589);
            this.trvFiles.TabIndex = 33;
            // 
            // listFiles
            // 
            this.listFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPackage});
            this.listFiles.FullRowSelect = true;
            this.listFiles.GridLines = true;
            this.listFiles.HideSelection = false;
            this.listFiles.Location = new System.Drawing.Point(-1, 0);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(313, 589);
            this.listFiles.TabIndex = 32;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            this.listFiles.View = System.Windows.Forms.View.Details;
            // 
            // colPackage
            // 
            this.colPackage.Text = "Package";
            this.colPackage.Width = 306;
            // 
            // tbConflicts
            // 
            this.tbConflicts.Controls.Add(this.trvConflicts);
            this.tbConflicts.Controls.Add(this.panel1);
            this.tbConflicts.Location = new System.Drawing.Point(4, 22);
            this.tbConflicts.Name = "tbConflicts";
            this.tbConflicts.Padding = new System.Windows.Forms.Padding(3);
            this.tbConflicts.Size = new System.Drawing.Size(1534, 630);
            this.tbConflicts.TabIndex = 1;
            this.tbConflicts.Text = "Conflicts (1)";
            this.tbConflicts.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 560);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1528, 67);
            this.panel1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 595);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // trvConflicts
            // 
            this.trvConflicts.Location = new System.Drawing.Point(6, 3);
            this.trvConflicts.Name = "trvConflicts";
            treeNode7.Name = "nodePkg";
            treeNode7.Text = "PkgMapTemplate";
            treeNode8.Name = "nodePkg";
            treeNode8.Text = "PkgCustomPerk1";
            treeNode9.Name = "nodeFileName";
            treeNode9.Text = "FileXY.gdt";
            this.trvConflicts.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.trvConflicts.Size = new System.Drawing.Size(481, 551);
            this.trvConflicts.TabIndex = 38;
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
            this.Controls.Add(this.btnNewFileList);
            this.Controls.Add(this.lblFileListFile);
            this.Controls.Add(this.btnBrowseFileList);
            this.Controls.Add(this.txtFileList);
            this.Controls.Add(this.lblGameRoot);
            this.Controls.Add(this.lblRepo);
            this.Controls.Add(this.btnBrowseGameRoot);
            this.Controls.Add(this.btnBrowseRepo);
            this.Controls.Add(this.txtGameRoot);
            this.Controls.Add(this.txtPathRepo);
            this.Name = "FrmMain";
            this.Text = "Content Manager";
            this.tbcOperations.ResumeLayout(false);
            this.tbContent.ResumeLayout(false);
            this.tbContent.PerformLayout();
            this.tbConflicts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackupFolder;
        private System.Windows.Forms.Button btnBackupDir;
        private System.Windows.Forms.TextBox txtBackupDir;
        private System.Windows.Forms.Button btnNewFileList;
        private System.Windows.Forms.Label lblFileListFile;
        private System.Windows.Forms.Button btnBrowseFileList;
        private System.Windows.Forms.TextBox txtFileList;
        private System.Windows.Forms.Label lblGameRoot;
        private System.Windows.Forms.Label lblRepo;
        private System.Windows.Forms.Button btnBrowseGameRoot;
        private System.Windows.Forms.Button btnBrowseRepo;
        private System.Windows.Forms.TextBox txtGameRoot;
        private System.Windows.Forms.TextBox txtPathRepo;
        private System.Windows.Forms.TabControl tbcOperations;
        private System.Windows.Forms.TabPage tbContent;
        private System.Windows.Forms.TreeView trvFiles;
        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.ColumnHeader colPackage;
        private System.Windows.Forms.TabPage tbConflicts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPackageID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPackagePath;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView trvConflicts;
    }
}

