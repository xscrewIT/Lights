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
    public partial class garażOgólne : Form
    {
        public garażOgólne()
        {
            InitializeComponent();
        }

        private void btnOświetlenieZewON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?G11");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOświetlenieZewOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?G10");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKinkietyON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?G21");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKinkietyOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?G20");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLampyNaBelkachON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?G31");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLampyNaBelkachOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?G30");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStrychON_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?G41");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStrychOFF_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new WebClient().DownloadString("http://19.168.2.10/?G40");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
