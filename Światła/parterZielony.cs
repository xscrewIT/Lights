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
    public partial class parterZielony : Form
    {
        public parterZielony()
        {
            InitializeComponent();
        }

        private void btnLampaSufit1ON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?S51");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLampaSufit1OFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?S50");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLampaSufit2ON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?S61");
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
                var data = new WebClient().DownloadString("http://192.168.2.10/?S60");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
