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
    public partial class parterCzerwony : Form
    {
        public parterCzerwony()
        {
            InitializeComponent();
        }

        private void btnLampaSufit2ON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?S31");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLampaSufit2OFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?S30");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLampaSufit3ON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?S41");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLampaSufit3OFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?S40");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
