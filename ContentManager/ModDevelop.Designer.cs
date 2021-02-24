
namespace ContentManager
{
    partial class ModDevelop
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
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chkSearchFilter = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chkGameRootAndRepoMissing = new System.Windows.Forms.CheckBox();
            this.chkRepoIsMissing = new System.Windows.Forms.CheckBox();
            this.chkGameRootIsMissing = new System.Windows.Forms.CheckBox();
            this.chkFilesEven = new System.Windows.Forms.CheckBox();
            this.chkRepoIsNewer = new System.Windows.Forms.CheckBox();
            this.chkGameRootIsNewer = new System.Windows.Forms.CheckBox();
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.btnAddUnlisted = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.grpRepository = new System.Windows.Forms.GroupBox();
            this.btnCopyToGameRoot = new System.Windows.Forms.Button();
            this.listFiles = new System.Windows.Forms.ListView();
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastChangedRepo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastChangedGR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpGameRoot = new System.Windows.Forms.GroupBox();
            this.btnCopyToRepo = new System.Windows.Forms.Button();
            this.grpFilter.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpFiles.SuspendLayout();
            this.grpRepository.SuspendLayout();
            this.grpGameRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompare.Location = new System.Drawing.Point(466, 545);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(114, 23);
            this.btnCompare.TabIndex = 20;
            this.btnCompare.Text = " <= Compare =>";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(1390, 619);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 25;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
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
            this.grpFilter.Location = new System.Drawing.Point(804, 526);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(566, 116);
            this.grpFilter.TabIndex = 24;
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
            // grpFiles
            // 
            this.grpFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpFiles.Controls.Add(this.btnAddUnlisted);
            this.grpFiles.Controls.Add(this.btnRemoveFile);
            this.grpFiles.Controls.Add(this.btnAddFile);
            this.grpFiles.Location = new System.Drawing.Point(3, 526);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(228, 116);
            this.grpFiles.TabIndex = 22;
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
            // grpRepository
            // 
            this.grpRepository.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpRepository.Controls.Add(this.btnCopyToGameRoot);
            this.grpRepository.Location = new System.Drawing.Point(237, 526);
            this.grpRepository.Name = "grpRepository";
            this.grpRepository.Size = new System.Drawing.Size(223, 116);
            this.grpRepository.TabIndex = 21;
            this.grpRepository.TabStop = false;
            this.grpRepository.Text = "Repository";
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
            this.listFiles.Location = new System.Drawing.Point(3, 3);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(1462, 517);
            this.listFiles.TabIndex = 19;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            this.listFiles.View = System.Windows.Forms.View.Details;
            this.listFiles.SelectedIndexChanged += new System.EventHandler(this.listFiles_SelectedIndexChanged);
            // 
            // colFile
            // 
            this.colFile.Text = "Relative file path";
            this.colFile.Width = 780;
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
            // grpGameRoot
            // 
            this.grpGameRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpGameRoot.Controls.Add(this.btnCopyToRepo);
            this.grpGameRoot.Location = new System.Drawing.Point(586, 526);
            this.grpGameRoot.Name = "grpGameRoot";
            this.grpGameRoot.Size = new System.Drawing.Size(212, 116);
            this.grpGameRoot.TabIndex = 23;
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
            // ModDevelop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpFiles);
            this.Controls.Add(this.grpRepository);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.grpGameRoot);
            this.Name = "ModDevelop";
            this.Size = new System.Drawing.Size(1468, 645);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpFiles.ResumeLayout(false);
            this.grpRepository.ResumeLayout(false);
            this.grpGameRoot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkSearchFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox chkGameRootAndRepoMissing;
        private System.Windows.Forms.CheckBox chkRepoIsMissing;
        private System.Windows.Forms.CheckBox chkGameRootIsMissing;
        private System.Windows.Forms.CheckBox chkFilesEven;
        private System.Windows.Forms.CheckBox chkRepoIsNewer;
        private System.Windows.Forms.CheckBox chkGameRootIsNewer;
        private System.Windows.Forms.GroupBox grpFiles;
        private System.Windows.Forms.Button btnAddUnlisted;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.GroupBox grpRepository;
        private System.Windows.Forms.Button btnCopyToGameRoot;
        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colLastChangedRepo;
        private System.Windows.Forms.ColumnHeader colLastChangedGR;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.GroupBox grpGameRoot;
        private System.Windows.Forms.Button btnCopyToRepo;
    }
}
