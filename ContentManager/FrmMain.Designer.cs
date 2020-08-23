﻿namespace ContentManager
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
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("PkgMapTemplate");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("PkgCustomPerk1");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("FileXY.gdt", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            this.lblBackupFolder = new System.Windows.Forms.Label();
            this.btnBackupDir = new System.Windows.Forms.Button();
            this.txtBackupDir = new System.Windows.Forms.TextBox();
            this.btnNewFileList = new System.Windows.Forms.Button();
            this.lblProjectFile = new System.Windows.Forms.Label();
            this.btnBrowseFileList = new System.Windows.Forms.Button();
            this.txtFileList = new System.Windows.Forms.TextBox();
            this.lblGameRoot = new System.Windows.Forms.Label();
            this.lblStorage = new System.Windows.Forms.Label();
            this.btnBrowseGameRoot = new System.Windows.Forms.Button();
            this.btnBrowseRepo = new System.Windows.Forms.Button();
            this.txtGameRoot = new System.Windows.Forms.TextBox();
            this.txtPathRepo = new System.Windows.Forms.TextBox();
            this.tbcOperations = new System.Windows.Forms.TabControl();
            this.tbContent = new System.Windows.Forms.TabPage();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lstCredits = new System.Windows.Forms.ListBox();
            this.lblPackageSize = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblPackagePath = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblPackageID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trvFiles = new System.Windows.Forms.TreeView();
            this.listFiles = new System.Windows.Forms.ListView();
            this.colPackage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbConflicts = new System.Windows.Forms.TabPage();
            this.grpAutomatic = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.grpFileOp = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.trvConflicts = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExec = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tbcOperations.SuspendLayout();
            this.tbContent.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbConflicts.SuspendLayout();
            this.grpAutomatic.SuspendLayout();
            this.grpFileOp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBackupFolder
            // 
            this.lblBackupFolder.AutoSize = true;
            this.lblBackupFolder.Location = new System.Drawing.Point(10, 87);
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
            // lblProjectFile
            // 
            this.lblProjectFile.AutoSize = true;
            this.lblProjectFile.Location = new System.Drawing.Point(12, 62);
            this.lblProjectFile.Name = "lblProjectFile";
            this.lblProjectFile.Size = new System.Drawing.Size(56, 13);
            this.lblProjectFile.TabIndex = 25;
            this.lblProjectFile.Text = "Project file";
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
            this.lblGameRoot.Location = new System.Drawing.Point(12, 36);
            this.lblGameRoot.Name = "lblGameRoot";
            this.lblGameRoot.Size = new System.Drawing.Size(56, 13);
            this.lblGameRoot.TabIndex = 22;
            this.lblGameRoot.Text = "Game root";
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Location = new System.Drawing.Point(22, 10);
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
            this.tbcOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcOperations.Controls.Add(this.tbContent);
            this.tbcOperations.Controls.Add(this.tbConflicts);
            this.tbcOperations.Location = new System.Drawing.Point(12, 110);
            this.tbcOperations.Name = "tbcOperations";
            this.tbcOperations.SelectedIndex = 0;
            this.tbcOperations.Size = new System.Drawing.Size(1542, 671);
            this.tbcOperations.TabIndex = 32;
            // 
            // tbContent
            // 
            this.tbContent.Controls.Add(this.grpActions);
            this.tbContent.Controls.Add(this.lblStatus);
            this.tbContent.Controls.Add(this.textBox6);
            this.tbContent.Controls.Add(this.lblCredits);
            this.tbContent.Controls.Add(this.lstCredits);
            this.tbContent.Controls.Add(this.lblPackageSize);
            this.tbContent.Controls.Add(this.textBox4);
            this.tbContent.Controls.Add(this.lblPackagePath);
            this.tbContent.Controls.Add(this.textBox3);
            this.tbContent.Controls.Add(this.lblPackageID);
            this.tbContent.Controls.Add(this.textBox2);
            this.tbContent.Controls.Add(this.lblPackageName);
            this.tbContent.Controls.Add(this.textBox1);
            this.tbContent.Controls.Add(this.trvFiles);
            this.tbContent.Controls.Add(this.listFiles);
            this.tbContent.Controls.Add(this.panel2);
            this.tbContent.Location = new System.Drawing.Point(4, 22);
            this.tbContent.Name = "tbContent";
            this.tbContent.Padding = new System.Windows.Forms.Padding(3);
            this.tbContent.Size = new System.Drawing.Size(1534, 645);
            this.tbContent.TabIndex = 0;
            this.tbContent.Text = "Content";
            this.tbContent.UseVisualStyleBackColor = true;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnRefresh);
            this.grpActions.Controls.Add(this.button4);
            this.grpActions.Controls.Add(this.btnInstall);
            this.grpActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpActions.Location = new System.Drawing.Point(588, 511);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(943, 100);
            this.grpActions.TabIndex = 51;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(9, 47);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(123, 22);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(684, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 22);
            this.button4.TabIndex = 45;
            this.button4.Text = "Remove Package";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(813, 47);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(123, 22);
            this.btnInstall.TabIndex = 44;
            this.btnInstall.Text = "Install Package";
            this.btnInstall.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(953, 72);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 13);
            this.lblStatus.TabIndex = 50;
            this.lblStatus.Text = "Package status:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1043, 69);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 49;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(594, 96);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(87, 13);
            this.lblCredits.TabIndex = 48;
            this.lblCredits.Text = "Package credits:";
            // 
            // lstCredits
            // 
            this.lstCredits.FormattingEnabled = true;
            this.lstCredits.Location = new System.Drawing.Point(687, 96);
            this.lstCredits.Name = "lstCredits";
            this.lstCredits.Size = new System.Drawing.Size(277, 186);
            this.lstCredits.TabIndex = 47;
            // 
            // lblPackageSize
            // 
            this.lblPackageSize.AutoSize = true;
            this.lblPackageSize.Location = new System.Drawing.Point(607, 72);
            this.lblPackageSize.Name = "lblPackageSize";
            this.lblPackageSize.Size = new System.Drawing.Size(74, 13);
            this.lblPackageSize.TabIndex = 46;
            this.lblPackageSize.Text = "Package size:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(687, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(62, 20);
            this.textBox4.TabIndex = 45;
            // 
            // lblPackagePath
            // 
            this.lblPackagePath.AutoSize = true;
            this.lblPackagePath.Location = new System.Drawing.Point(604, 20);
            this.lblPackagePath.Name = "lblPackagePath";
            this.lblPackagePath.Size = new System.Drawing.Size(77, 13);
            this.lblPackagePath.TabIndex = 40;
            this.lblPackagePath.Text = "Package path:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(687, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(456, 20);
            this.textBox3.TabIndex = 39;
            // 
            // lblPackageID
            // 
            this.lblPackageID.AutoSize = true;
            this.lblPackageID.Location = new System.Drawing.Point(970, 46);
            this.lblPackageID.Name = "lblPackageID";
            this.lblPackageID.Size = new System.Drawing.Size(67, 13);
            this.lblPackageID.TabIndex = 38;
            this.lblPackageID.Text = "Package ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1043, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 37;
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Location = new System.Drawing.Point(599, 46);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(82, 13);
            this.lblPackageName.TabIndex = 35;
            this.lblPackageName.Text = "Package name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(687, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 34;
            // 
            // trvFiles
            // 
            this.trvFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvFiles.Location = new System.Drawing.Point(216, 3);
            this.trvFiles.Name = "trvFiles";
            this.trvFiles.Size = new System.Drawing.Size(372, 608);
            this.trvFiles.TabIndex = 33;
            // 
            // listFiles
            // 
            this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPackage});
            this.listFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.listFiles.FullRowSelect = true;
            this.listFiles.GridLines = true;
            this.listFiles.HideSelection = false;
            this.listFiles.Location = new System.Drawing.Point(3, 3);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(213, 608);
            this.listFiles.TabIndex = 32;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            this.listFiles.View = System.Windows.Forms.View.Details;
            // 
            // colPackage
            // 
            this.colPackage.Text = "Package";
            this.colPackage.Width = 204;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 611);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1528, 31);
            this.panel2.TabIndex = 44;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(139, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(62, 24);
            this.btnRemove.TabIndex = 42;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(71, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(62, 24);
            this.btnImport.TabIndex = 41;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(62, 24);
            this.btnCreate.TabIndex = 43;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbConflicts
            // 
            this.tbConflicts.Controls.Add(this.grpAutomatic);
            this.tbConflicts.Controls.Add(this.button1);
            this.tbConflicts.Controls.Add(this.comboBox1);
            this.tbConflicts.Controls.Add(this.comboBox2);
            this.tbConflicts.Controls.Add(this.grpFileOp);
            this.tbConflicts.Controls.Add(this.trvConflicts);
            this.tbConflicts.Controls.Add(this.panel1);
            this.tbConflicts.Location = new System.Drawing.Point(4, 22);
            this.tbConflicts.Name = "tbConflicts";
            this.tbConflicts.Padding = new System.Windows.Forms.Padding(3);
            this.tbConflicts.Size = new System.Drawing.Size(1534, 645);
            this.tbConflicts.TabIndex = 1;
            this.tbConflicts.Text = "Conflicts (1)";
            this.tbConflicts.UseVisualStyleBackColor = true;
            // 
            // grpAutomatic
            // 
            this.grpAutomatic.Controls.Add(this.button3);
            this.grpAutomatic.Location = new System.Drawing.Point(493, 134);
            this.grpAutomatic.Name = "grpAutomatic";
            this.grpAutomatic.Size = new System.Drawing.Size(444, 192);
            this.grpAutomatic.TabIndex = 59;
            this.grpAutomatic.TabStop = false;
            this.grpAutomatic.Text = "Automatic";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 23);
            this.button3.TabIndex = 58;
            this.button3.Text = "Apply state from root folder";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 21);
            this.button1.TabIndex = 57;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(728, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 54;
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(506, 107);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 21);
            this.comboBox2.TabIndex = 55;
            // 
            // grpFileOp
            // 
            this.grpFileOp.Controls.Add(this.radioButton3);
            this.grpFileOp.Controls.Add(this.button2);
            this.grpFileOp.Controls.Add(this.btnSelect);
            this.grpFileOp.Controls.Add(this.textBox5);
            this.grpFileOp.Controls.Add(this.radioButton2);
            this.grpFileOp.Controls.Add(this.radioButton1);
            this.grpFileOp.Location = new System.Drawing.Point(493, 6);
            this.grpFileOp.Name = "grpFileOp";
            this.grpFileOp.Size = new System.Drawing.Size(444, 95);
            this.grpFileOp.TabIndex = 53;
            this.grpFileOp.TabStop = false;
            this.grpFileOp.Text = "Use file from ...";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(397, 40);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(40, 21);
            this.btnSelect.TabIndex = 56;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(148, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(243, 20);
            this.textBox5.TabIndex = 55;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 17);
            this.radioButton2.TabIndex = 53;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "other package";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 17);
            this.radioButton1.TabIndex = 52;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "this package";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // trvConflicts
            // 
            this.trvConflicts.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvConflicts.Location = new System.Drawing.Point(3, 3);
            this.trvConflicts.Name = "trvConflicts";
            treeNode22.Name = "nodePkg";
            treeNode22.Text = "PkgMapTemplate";
            treeNode23.Name = "nodePkg";
            treeNode23.Text = "PkgCustomPerk1";
            treeNode24.Name = "nodeFileName";
            treeNode24.Text = "FileXY.gdt";
            this.trvConflicts.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24});
            this.trvConflicts.Size = new System.Drawing.Size(481, 610);
            this.trvConflicts.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.btnExec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 613);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1528, 29);
            this.panel1.TabIndex = 37;
            // 
            // btnExec
            // 
            this.btnExec.Enabled = false;
            this.btnExec.Location = new System.Drawing.Point(1311, 3);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(214, 23);
            this.btnExec.TabIndex = 0;
            this.btnExec.Text = "Save";
            this.btnExec.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 21);
            this.button2.TabIndex = 57;
            this.button2.Text = "Add file from root to new pkg";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 58;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "root folder";
            this.radioButton3.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.lblProjectFile);
            this.Controls.Add(this.btnBrowseFileList);
            this.Controls.Add(this.txtFileList);
            this.Controls.Add(this.lblGameRoot);
            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.btnBrowseGameRoot);
            this.Controls.Add(this.btnBrowseRepo);
            this.Controls.Add(this.txtGameRoot);
            this.Controls.Add(this.txtPathRepo);
            this.Name = "FrmMain";
            this.Text = "Content Manager";
            this.tbcOperations.ResumeLayout(false);
            this.tbContent.ResumeLayout(false);
            this.tbContent.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tbConflicts.ResumeLayout(false);
            this.grpAutomatic.ResumeLayout(false);
            this.grpFileOp.ResumeLayout(false);
            this.grpFileOp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackupFolder;
        private System.Windows.Forms.Button btnBackupDir;
        private System.Windows.Forms.TextBox txtBackupDir;
        private System.Windows.Forms.Button btnNewFileList;
        private System.Windows.Forms.Label lblProjectFile;
        private System.Windows.Forms.Button btnBrowseFileList;
        private System.Windows.Forms.TextBox txtFileList;
        private System.Windows.Forms.Label lblGameRoot;
        private System.Windows.Forms.Label lblStorage;
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
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPackageID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPackagePath;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TreeView trvConflicts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPackageSize;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.ListBox lstCredits;
        private System.Windows.Forms.GroupBox grpFileOp;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox grpAutomatic;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

