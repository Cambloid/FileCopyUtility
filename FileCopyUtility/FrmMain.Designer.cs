namespace FileCopyUtility
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
            this.listFiles = new System.Windows.Forms.ListView();
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastChangedRepo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastChangedGR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCopyToGameRoot = new System.Windows.Forms.Button();
            this.grpRepository = new System.Windows.Forms.GroupBox();
            this.grpGameRoot = new System.Windows.Forms.GroupBox();
            this.btnCopyToRepo = new System.Windows.Forms.Button();
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.btnAddUnlisted = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtPathRepo = new System.Windows.Forms.TextBox();
            this.txtGameRoot = new System.Windows.Forms.TextBox();
            this.btnBrowseRepo = new System.Windows.Forms.Button();
            this.btnBrowseGameRoot = new System.Windows.Forms.Button();
            this.lblRepo = new System.Windows.Forms.Label();
            this.lblGameRoot = new System.Windows.Forms.Label();
            this.lblFileListFile = new System.Windows.Forms.Label();
            this.btnBrowseFileList = new System.Windows.Forms.Button();
            this.txtFileList = new System.Windows.Forms.TextBox();
            this.btnNewFileList = new System.Windows.Forms.Button();
            this.lblBackupFolder = new System.Windows.Forms.Label();
            this.btnBackupDir = new System.Windows.Forms.Button();
            this.txtBackupDir = new System.Windows.Forms.TextBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chkSearchFilter = new System.Windows.Forms.CheckBox();
            this.chkGameRootAndRepoMissing = new System.Windows.Forms.CheckBox();
            this.chkRepoIsMissing = new System.Windows.Forms.CheckBox();
            this.chkGameRootIsMissing = new System.Windows.Forms.CheckBox();
            this.chkFilesEven = new System.Windows.Forms.CheckBox();
            this.chkRepoIsNewer = new System.Windows.Forms.CheckBox();
            this.chkGameRootIsNewer = new System.Windows.Forms.CheckBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.grpRepository.SuspendLayout();
            this.grpGameRoot.SuspendLayout();
            this.grpFiles.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // listFiles
            // 
            this.listFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFile,
            this.colLastChangedRepo,
            this.colLastChangedGR,
            this.colStatus});
            this.listFiles.FullRowSelect = true;
            this.listFiles.GridLines = true;
            this.listFiles.HideSelection = false;
            this.listFiles.Location = new System.Drawing.Point(12, 117);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(1551, 512);
            this.listFiles.TabIndex = 0;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            this.listFiles.View = System.Windows.Forms.View.Details;
            this.listFiles.SelectedIndexChanged += new System.EventHandler(this.listFiles_SelectedIndexChanged);
            // 
            // colFile
            // 
            this.colFile.Text = "Relative file path";
            this.colFile.Width = 1015;
            // 
            // colLastChangedRepo
            // 
            this.colLastChangedRepo.Text = "Last changed Repository";
            this.colLastChangedRepo.Width = 147;
            // 
            // colLastChangedGR
            // 
            this.colLastChangedGR.Text = "Last changed gameroot";
            this.colLastChangedGR.Width = 132;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 178;
            // 
            // btnCopyToGameRoot
            // 
            this.btnCopyToGameRoot.Location = new System.Drawing.Point(6, 19);
            this.btnCopyToGameRoot.Name = "btnCopyToGameRoot";
            this.btnCopyToGameRoot.Size = new System.Drawing.Size(211, 23);
            this.btnCopyToGameRoot.TabIndex = 1;
            this.btnCopyToGameRoot.Text = "Copy to gameroot";
            this.btnCopyToGameRoot.UseVisualStyleBackColor = true;
            this.btnCopyToGameRoot.Click += new System.EventHandler(this.btnCopyToGameRoot_Click);
            // 
            // grpRepository
            // 
            this.grpRepository.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpRepository.Controls.Add(this.btnCopyToGameRoot);
            this.grpRepository.Location = new System.Drawing.Point(246, 635);
            this.grpRepository.Name = "grpRepository";
            this.grpRepository.Size = new System.Drawing.Size(223, 116);
            this.grpRepository.TabIndex = 2;
            this.grpRepository.TabStop = false;
            this.grpRepository.Text = "Repository";
            // 
            // grpGameRoot
            // 
            this.grpGameRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpGameRoot.Controls.Add(this.btnCopyToRepo);
            this.grpGameRoot.Location = new System.Drawing.Point(595, 635);
            this.grpGameRoot.Name = "grpGameRoot";
            this.grpGameRoot.Size = new System.Drawing.Size(212, 116);
            this.grpGameRoot.TabIndex = 3;
            this.grpGameRoot.TabStop = false;
            this.grpGameRoot.Text = "Game root";
            // 
            // btnCopyToRepo
            // 
            this.btnCopyToRepo.Location = new System.Drawing.Point(6, 19);
            this.btnCopyToRepo.Name = "btnCopyToRepo";
            this.btnCopyToRepo.Size = new System.Drawing.Size(200, 23);
            this.btnCopyToRepo.TabIndex = 1;
            this.btnCopyToRepo.Text = "Copy to repository";
            this.btnCopyToRepo.UseVisualStyleBackColor = true;
            this.btnCopyToRepo.Click += new System.EventHandler(this.btnCopyToRepo_Click);
            // 
            // grpFiles
            // 
            this.grpFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpFiles.Controls.Add(this.btnAddUnlisted);
            this.grpFiles.Controls.Add(this.btnRemoveFile);
            this.grpFiles.Controls.Add(this.btnAddFile);
            this.grpFiles.Location = new System.Drawing.Point(12, 635);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(228, 116);
            this.grpFiles.TabIndex = 3;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "Files";
            // 
            // btnAddUnlisted
            // 
            this.btnAddUnlisted.Location = new System.Drawing.Point(6, 47);
            this.btnAddUnlisted.Name = "btnAddUnlisted";
            this.btnAddUnlisted.Size = new System.Drawing.Size(216, 23);
            this.btnAddUnlisted.TabIndex = 3;
            this.btnAddUnlisted.Text = "Find not listed files from repo";
            this.btnAddUnlisted.UseVisualStyleBackColor = true;
            this.btnAddUnlisted.Click += new System.EventHandler(this.btnAddUnlisted_Click);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(6, 76);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(216, 23);
            this.btnRemoveFile.TabIndex = 2;
            this.btnRemoveFile.Text = "Remove from list";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(6, 19);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(216, 23);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "Add to list";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 88);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(553, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtPathRepo
            // 
            this.txtPathRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathRepo.Location = new System.Drawing.Point(75, 12);
            this.txtPathRepo.Name = "txtPathRepo";
            this.txtPathRepo.ReadOnly = true;
            this.txtPathRepo.Size = new System.Drawing.Size(1428, 20);
            this.txtPathRepo.TabIndex = 4;
            // 
            // txtGameRoot
            // 
            this.txtGameRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameRoot.Location = new System.Drawing.Point(75, 38);
            this.txtGameRoot.Name = "txtGameRoot";
            this.txtGameRoot.ReadOnly = true;
            this.txtGameRoot.Size = new System.Drawing.Size(1428, 20);
            this.txtGameRoot.TabIndex = 5;
            // 
            // btnBrowseRepo
            // 
            this.btnBrowseRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseRepo.Location = new System.Drawing.Point(1509, 12);
            this.btnBrowseRepo.Name = "btnBrowseRepo";
            this.btnBrowseRepo.Size = new System.Drawing.Size(54, 20);
            this.btnBrowseRepo.TabIndex = 6;
            this.btnBrowseRepo.Text = "...";
            this.btnBrowseRepo.UseVisualStyleBackColor = true;
            this.btnBrowseRepo.Click += new System.EventHandler(this.btnBrowseRepo_Click);
            // 
            // btnBrowseGameRoot
            // 
            this.btnBrowseGameRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseGameRoot.Location = new System.Drawing.Point(1509, 38);
            this.btnBrowseGameRoot.Name = "btnBrowseGameRoot";
            this.btnBrowseGameRoot.Size = new System.Drawing.Size(54, 20);
            this.btnBrowseGameRoot.TabIndex = 7;
            this.btnBrowseGameRoot.Text = "...";
            this.btnBrowseGameRoot.UseVisualStyleBackColor = true;
            this.btnBrowseGameRoot.Click += new System.EventHandler(this.btnBrowseGameRoot_Click);
            // 
            // lblRepo
            // 
            this.lblRepo.AutoSize = true;
            this.lblRepo.Location = new System.Drawing.Point(15, 15);
            this.lblRepo.Name = "lblRepo";
            this.lblRepo.Size = new System.Drawing.Size(57, 13);
            this.lblRepo.TabIndex = 8;
            this.lblRepo.Text = "Repository";
            // 
            // lblGameRoot
            // 
            this.lblGameRoot.AutoSize = true;
            this.lblGameRoot.Location = new System.Drawing.Point(15, 40);
            this.lblGameRoot.Name = "lblGameRoot";
            this.lblGameRoot.Size = new System.Drawing.Size(56, 13);
            this.lblGameRoot.TabIndex = 9;
            this.lblGameRoot.Text = "Game root";
            // 
            // lblFileListFile
            // 
            this.lblFileListFile.AutoSize = true;
            this.lblFileListFile.Location = new System.Drawing.Point(15, 66);
            this.lblFileListFile.Name = "lblFileListFile";
            this.lblFileListFile.Size = new System.Drawing.Size(38, 13);
            this.lblFileListFile.TabIndex = 12;
            this.lblFileListFile.Text = "File list";
            // 
            // btnBrowseFileList
            // 
            this.btnBrowseFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFileList.Location = new System.Drawing.Point(1509, 64);
            this.btnBrowseFileList.Name = "btnBrowseFileList";
            this.btnBrowseFileList.Size = new System.Drawing.Size(54, 20);
            this.btnBrowseFileList.TabIndex = 11;
            this.btnBrowseFileList.Text = "...";
            this.btnBrowseFileList.UseVisualStyleBackColor = true;
            this.btnBrowseFileList.Click += new System.EventHandler(this.btnBrowseFileList_Click);
            // 
            // txtFileList
            // 
            this.txtFileList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileList.Location = new System.Drawing.Point(75, 64);
            this.txtFileList.Name = "txtFileList";
            this.txtFileList.ReadOnly = true;
            this.txtFileList.Size = new System.Drawing.Size(1393, 20);
            this.txtFileList.TabIndex = 10;
            // 
            // btnNewFileList
            // 
            this.btnNewFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewFileList.Location = new System.Drawing.Point(1474, 64);
            this.btnNewFileList.Name = "btnNewFileList";
            this.btnNewFileList.Size = new System.Drawing.Size(29, 20);
            this.btnNewFileList.TabIndex = 13;
            this.btnNewFileList.Text = "+";
            this.btnNewFileList.UseVisualStyleBackColor = true;
            this.btnNewFileList.Click += new System.EventHandler(this.btnNewFileList_Click);
            // 
            // lblBackupFolder
            // 
            this.lblBackupFolder.AutoSize = true;
            this.lblBackupFolder.Location = new System.Drawing.Point(15, 93);
            this.lblBackupFolder.Name = "lblBackupFolder";
            this.lblBackupFolder.Size = new System.Drawing.Size(58, 13);
            this.lblBackupFolder.TabIndex = 16;
            this.lblBackupFolder.Text = "Backup dir";
            // 
            // btnBackupDir
            // 
            this.btnBackupDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackupDir.Location = new System.Drawing.Point(1509, 90);
            this.btnBackupDir.Name = "btnBackupDir";
            this.btnBackupDir.Size = new System.Drawing.Size(54, 20);
            this.btnBackupDir.TabIndex = 15;
            this.btnBackupDir.Text = "...";
            this.btnBackupDir.UseVisualStyleBackColor = true;
            // 
            // txtBackupDir
            // 
            this.txtBackupDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackupDir.Location = new System.Drawing.Point(75, 90);
            this.txtBackupDir.Name = "txtBackupDir";
            this.txtBackupDir.ReadOnly = true;
            this.txtBackupDir.Size = new System.Drawing.Size(1428, 20);
            this.txtBackupDir.TabIndex = 14;
            // 
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpFilter.Controls.Add(this.grpSearch);
            this.grpFilter.Controls.Add(this.btnRefresh);
            this.grpFilter.Controls.Add(this.chkGameRootAndRepoMissing);
            this.grpFilter.Controls.Add(this.chkRepoIsMissing);
            this.grpFilter.Controls.Add(this.chkGameRootIsMissing);
            this.grpFilter.Controls.Add(this.chkFilesEven);
            this.grpFilter.Controls.Add(this.chkRepoIsNewer);
            this.grpFilter.Controls.Add(this.chkGameRootIsNewer);
            this.grpFilter.Location = new System.Drawing.Point(813, 635);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(566, 116);
            this.grpFilter.TabIndex = 17;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.chkSearchFilter);
            this.grpSearch.Location = new System.Drawing.Point(304, 9);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(255, 73);
            this.grpSearch.TabIndex = 9;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(243, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // chkSearchFilter
            // 
            this.chkSearchFilter.AutoSize = true;
            this.chkSearchFilter.Location = new System.Drawing.Point(6, 19);
            this.chkSearchFilter.Name = "chkSearchFilter";
            this.chkSearchFilter.Size = new System.Drawing.Size(79, 17);
            this.chkSearchFilter.TabIndex = 7;
            this.chkSearchFilter.Text = "Searchfilter";
            this.chkSearchFilter.UseVisualStyleBackColor = true;
            // 
            // chkGameRootAndRepoMissing
            // 
            this.chkGameRootAndRepoMissing.AutoSize = true;
            this.chkGameRootAndRepoMissing.Checked = true;
            this.chkGameRootAndRepoMissing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGameRootAndRepoMissing.Location = new System.Drawing.Point(128, 19);
            this.chkGameRootAndRepoMissing.Name = "chkGameRootAndRepoMissing";
            this.chkGameRootAndRepoMissing.Size = new System.Drawing.Size(170, 17);
            this.chkGameRootAndRepoMissing.TabIndex = 5;
            this.chkGameRootAndRepoMissing.Text = "Game root and repo. is missing";
            this.chkGameRootAndRepoMissing.UseVisualStyleBackColor = true;
            // 
            // chkRepoIsMissing
            // 
            this.chkRepoIsMissing.AutoSize = true;
            this.chkRepoIsMissing.Checked = true;
            this.chkRepoIsMissing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRepoIsMissing.Location = new System.Drawing.Point(129, 65);
            this.chkRepoIsMissing.Name = "chkRepoIsMissing";
            this.chkRepoIsMissing.Size = new System.Drawing.Size(123, 17);
            this.chkRepoIsMissing.TabIndex = 4;
            this.chkRepoIsMissing.Text = "Repository is missing";
            this.chkRepoIsMissing.UseVisualStyleBackColor = true;
            // 
            // chkGameRootIsMissing
            // 
            this.chkGameRootIsMissing.AutoSize = true;
            this.chkGameRootIsMissing.Checked = true;
            this.chkGameRootIsMissing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGameRootIsMissing.Location = new System.Drawing.Point(129, 42);
            this.chkGameRootIsMissing.Name = "chkGameRootIsMissing";
            this.chkGameRootIsMissing.Size = new System.Drawing.Size(122, 17);
            this.chkGameRootIsMissing.TabIndex = 3;
            this.chkGameRootIsMissing.Text = "Game root is missing";
            this.chkGameRootIsMissing.UseVisualStyleBackColor = true;
            // 
            // chkFilesEven
            // 
            this.chkFilesEven.AutoSize = true;
            this.chkFilesEven.Checked = true;
            this.chkFilesEven.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFilesEven.Location = new System.Drawing.Point(6, 19);
            this.chkFilesEven.Name = "chkFilesEven";
            this.chkFilesEven.Size = new System.Drawing.Size(92, 17);
            this.chkFilesEven.TabIndex = 2;
            this.chkFilesEven.Text = "Files are even";
            this.chkFilesEven.UseVisualStyleBackColor = true;
            // 
            // chkRepoIsNewer
            // 
            this.chkRepoIsNewer.AutoSize = true;
            this.chkRepoIsNewer.Checked = true;
            this.chkRepoIsNewer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRepoIsNewer.Location = new System.Drawing.Point(6, 65);
            this.chkRepoIsNewer.Name = "chkRepoIsNewer";
            this.chkRepoIsNewer.Size = new System.Drawing.Size(118, 17);
            this.chkRepoIsNewer.TabIndex = 1;
            this.chkRepoIsNewer.Text = "Repository is newer";
            this.chkRepoIsNewer.UseVisualStyleBackColor = true;
            // 
            // chkGameRootIsNewer
            // 
            this.chkGameRootIsNewer.AutoSize = true;
            this.chkGameRootIsNewer.Checked = true;
            this.chkGameRootIsNewer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGameRootIsNewer.Location = new System.Drawing.Point(6, 42);
            this.chkGameRootIsNewer.Name = "chkGameRootIsNewer";
            this.chkGameRootIsNewer.Size = new System.Drawing.Size(117, 17);
            this.chkGameRootIsNewer.TabIndex = 0;
            this.chkGameRootIsNewer.Text = "Game root is newer";
            this.chkGameRootIsNewer.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(1488, 728);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 18;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompare.Location = new System.Drawing.Point(475, 654);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(114, 23);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = " <= Compare =>";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 763);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.grpFilter);
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
            this.Controls.Add(this.grpFiles);
            this.Controls.Add(this.grpRepository);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.grpGameRoot);
            this.Name = "FrmMain";
            this.Text = "File copy utility";
            this.grpRepository.ResumeLayout(false);
            this.grpGameRoot.ResumeLayout(false);
            this.grpFiles.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Button btnCopyToGameRoot;
        private System.Windows.Forms.GroupBox grpRepository;
        private System.Windows.Forms.GroupBox grpGameRoot;
        private System.Windows.Forms.Button btnCopyToRepo;
        private System.Windows.Forms.GroupBox grpFiles;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.TextBox txtPathRepo;
        private System.Windows.Forms.TextBox txtGameRoot;
        private System.Windows.Forms.Button btnBrowseRepo;
        private System.Windows.Forms.Button btnBrowseGameRoot;
        private System.Windows.Forms.Label lblRepo;
        private System.Windows.Forms.Label lblGameRoot;
        private System.Windows.Forms.ColumnHeader colLastChangedRepo;
        private System.Windows.Forms.ColumnHeader colLastChangedGR;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblFileListFile;
        private System.Windows.Forms.Button btnBrowseFileList;
        private System.Windows.Forms.TextBox txtFileList;
        private System.Windows.Forms.Button btnNewFileList;
        private System.Windows.Forms.Label lblBackupFolder;
        private System.Windows.Forms.Button btnBackupDir;
        private System.Windows.Forms.TextBox txtBackupDir;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.CheckBox chkFilesEven;
        private System.Windows.Forms.CheckBox chkRepoIsNewer;
        private System.Windows.Forms.CheckBox chkGameRootIsNewer;
        private System.Windows.Forms.CheckBox chkGameRootIsMissing;
        private System.Windows.Forms.CheckBox chkRepoIsMissing;
        private System.Windows.Forms.CheckBox chkGameRootAndRepoMissing;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkSearchFilter;
        private System.Windows.Forms.Button btnAddUnlisted;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnCompare;
    }
}

