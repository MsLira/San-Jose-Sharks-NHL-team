using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace MLiraACP2_2
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void bkg_Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++) 
            {
                Thread.Sleep(50);
                bkg_Worker.ReportProgress(i);
            
            }
        }

        private void bkgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgrsBar.Value = e.ProgressPercentage;
            lbl_Pgss.Text = "Progress: " + e.ProgressPercentage.ToString() + "%";
            if (prgrsBar.Value >= 100)
            {
                new Form1().Show();
                this.Hide();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            bkg_Worker.WorkerReportsProgress = true;
            bkg_Worker.RunWorkerAsync();
        }
    }
}
