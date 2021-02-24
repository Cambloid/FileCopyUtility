namespace ContentManager
{
    partial class FrmRepoFileFinder
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
            this.colFileRepo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listFiles
            // 
            this.listFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFiles.CheckBoxes = true;
            this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileRepo});
            this.listFiles.FullRowSelect = true;
            this.listFiles.GridLines = true;
            this.listFiles.HideSelection = false;
            this.listFiles.Location = new System.Drawing.Point(12, 12);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(735, 684);
            this.listFiles.TabIndex = 1;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            this.listFiles.View = System.Windows.Forms.View.Details;
            // 
            // colFileRepo
            // 
            this.colFileRepo.Text = "File path repository";
            this.colFileRepo.Width = 728;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(594, 702);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.Location = new System.Drawing.Point(12, 702);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(153, 41);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "Select all";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // FrmRepoFileFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 755);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listFiles);
            this.Name = "FrmRepoFileFinder";
            this.Text = "Find not listed files";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.ColumnHeader colFileRepo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelectAll;
    }
}