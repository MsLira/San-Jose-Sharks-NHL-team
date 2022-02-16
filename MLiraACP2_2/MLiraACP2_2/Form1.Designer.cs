
namespace MLiraACP2_2
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bnt_CreateT = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_DisplayD = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_GenReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(95, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1178, 554);
            this.listBox1.TabIndex = 0;
            // 
            // bnt_CreateT
            // 
            this.bnt_CreateT.Location = new System.Drawing.Point(139, 646);
            this.bnt_CreateT.Name = "bnt_CreateT";
            this.bnt_CreateT.Size = new System.Drawing.Size(182, 61);
            this.bnt_CreateT.TabIndex = 1;
            this.bnt_CreateT.Text = "&Create Table";
            this.bnt_CreateT.UseVisualStyleBackColor = true;
            this.bnt_CreateT.Click += new System.EventHandler(this.bnt_CreateT_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(440, 646);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(182, 61);
            this.btn_Insert.TabIndex = 2;
            this.btn_Insert.Text = "&Insert Data";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_DisplayD
            // 
            this.btn_DisplayD.Location = new System.Drawing.Point(742, 646);
            this.btn_DisplayD.Name = "btn_DisplayD";
            this.btn_DisplayD.Size = new System.Drawing.Size(182, 61);
            this.btn_DisplayD.TabIndex = 3;
            this.btn_DisplayD.Text = "&Display Data";
            this.btn_DisplayD.UseVisualStyleBackColor = true;
            this.btn_DisplayD.Click += new System.EventHandler(this.btn_DisplayD_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1068, 843);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(182, 61);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_About
            // 
            this.btn_About.Location = new System.Drawing.Point(817, 843);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(182, 61);
            this.btn_About.TabIndex = 5;
            this.btn_About.Text = "&About";
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // btn_GenReport
            // 
            this.btn_GenReport.Location = new System.Drawing.Point(1043, 646);
            this.btn_GenReport.Name = "btn_GenReport";
            this.btn_GenReport.Size = new System.Drawing.Size(182, 61);
            this.btn_GenReport.TabIndex = 6;
            this.btn_GenReport.Text = "&Generate Report";
            this.btn_GenReport.UseVisualStyleBackColor = true;
            this.btn_GenReport.Click += new System.EventHandler(this.btn_GenReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1340, 944);
            this.Controls.Add(this.btn_GenReport);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_DisplayD);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.bnt_CreateT);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bnt_CreateT;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_DisplayD;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_GenReport;
    }
}

