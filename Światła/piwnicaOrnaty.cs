using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Światła
{
    public partial class piwnicaOrnaty : Form
    {
        public piwnicaOrnaty()
        {
            InitializeComponent();
        }

        private void btnLampaGórnaON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?X11");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLampaGórnaOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?X10");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReflektoryON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?X21");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReflektoryOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?X20");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrazyON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?X31");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrazyOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?X30");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResztaON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?X41");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResztaOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?X40");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
