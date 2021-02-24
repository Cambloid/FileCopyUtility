namespace ContentManager
{
    partial class FrmAbout
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
            this.picGyroid = new System.Windows.Forms.PictureBox();
            this.lblAbout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGyroid)).BeginInit();
            this.SuspendLayout();
            // 
            // picGyroid
            // 
            this.picGyroid.Image = global::ContentManager.Properties.Resources.gyroid;
            this.picGyroid.Location = new System.Drawing.Point(12, 12);
            this.picGyroid.Name = "picGyroid";
            this.picGyroid.Size = new System.Drawing.Size(217, 240);
            this.picGyroid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGyroid.TabIndex = 0;
            this.picGyroid.TabStop = false;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(96, 255);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(50, 26);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "Made by\r\nCambloid";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(241, 290);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.picGyroid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAbout";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.picGyroid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGyroid;
        private System.Windows.Forms.Label lblAbout;
    }
}