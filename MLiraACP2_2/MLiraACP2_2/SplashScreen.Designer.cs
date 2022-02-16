
namespace MLiraACP2_2
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.prgrsBar = new System.Windows.Forms.ProgressBar();
            this.lbl_Pgss = new System.Windows.Forms.Label();
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.bkg_Worker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // prgrsBar
            // 
            this.prgrsBar.Location = new System.Drawing.Point(30, 683);
            this.prgrsBar.Name = "prgrsBar";
            this.prgrsBar.Size = new System.Drawing.Size(1251, 60);
            this.prgrsBar.TabIndex = 0;
            // 
            // lbl_Pgss
            // 
            this.lbl_Pgss.AutoSize = true;
            this.lbl_Pgss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pgss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Pgss.Location = new System.Drawing.Point(619, 767);
            this.lbl_Pgss.Name = "lbl_Pgss";
            this.lbl_Pgss.Size = new System.Drawing.Size(85, 29);
            this.lbl_Pgss.TabIndex = 1;
            this.lbl_Pgss.Text = "label1";
            // 
            // pictBox
            // 
            this.pictBox.Image = ((System.Drawing.Image)(resources.GetObject("pictBox.Image")));
            this.pictBox.Location = new System.Drawing.Point(30, 12);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(1257, 644);
            this.pictBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox.TabIndex = 2;
            this.pictBox.TabStop = false;
            // 
            // bkg_Worker
            // 
            this.bkg_Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkg_Worker_DoWork);
            this.bkg_Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgWorker_ProgressChanged);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1319, 816);
            this.Controls.Add(this.pictBox);
            this.Controls.Add(this.lbl_Pgss);
            this.Controls.Add(this.prgrsBar);
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgrsBar;
        private System.Windows.Forms.Label lbl_Pgss;
        private System.Windows.Forms.PictureBox pictBox;
        private System.ComponentModel.BackgroundWorker bkg_Worker;
    }
}