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
    public partial class piwnicaOgólne : Form
    {
        public piwnicaOgólne()
        {
            InitializeComponent();
        }

        private void btnKorytarzON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T11");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKorytarzOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T10");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKotłowniaON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T21");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKotłowniaOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T20");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMałyKorytarzON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T31");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMałyKorytarzOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T30");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSkładzikON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T41");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSkładzikOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T40");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPralniaON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T51");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPralniaOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T50");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSchowekON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T61");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSchowekOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T60");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
