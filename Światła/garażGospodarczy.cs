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
    public partial class garażGospodarczy : Form
    {
        public garażGospodarczy()
        {
            InitializeComponent();
        }

        private void btnLampaSufitON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?G51");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLampaSufitOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?G50");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKinkietON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?G61");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKinkietOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?G60");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWC_ON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?G71");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWC_OFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?G70");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
