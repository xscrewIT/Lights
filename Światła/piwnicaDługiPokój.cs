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
    public partial class piwnicaDługiPokój : Form
    {
        public piwnicaDługiPokój()
        {
            InitializeComponent();
        }

        private void btnLampaPrzyWejściuON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T71");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLampaPrzyWejściuOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T70");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLampa2ON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T81");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLampa2OFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T80");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPiwniczkaON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T91");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPiwniczkaOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://192.168.2.10/?T90");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
