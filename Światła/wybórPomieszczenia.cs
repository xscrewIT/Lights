using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Światła
{
    public partial class wybórPomieszczenia : Form
    {
        public wybórPomieszczenia()
        {
            InitializeComponent();
        }

        private void btnParterNa_zewnątrz_Click(object sender, EventArgs e)
        {
            this.Hide();
            parterNa_zewnątrz parterNa_Zewnątrz = new parterNa_zewnątrz();
            parterNa_Zewnątrz.ShowDialog();
            this.Show();
        }

        private void btnParterKorytarz_Click(object sender, EventArgs e)
        {
            this.Hide();
            parterKorytarz parterKorytarz = new parterKorytarz();
            parterKorytarz.ShowDialog();
            this.Show();
        }

        private void btnParterSalon_Click(object sender, EventArgs e)
        {
            this.Hide();
            parterSalon parterSalon = new parterSalon();
            parterSalon.ShowDialog();
            this.Show();
        }

        private void btnParterKuchnia_Click(object sender, EventArgs e)
        {
            this.Hide();
            parterKuchnia parterKuchnia = new parterKuchnia();
            parterKuchnia.ShowDialog();
            this.Show();
        }

        private void btnParterWC_Click(object sender, EventArgs e)
        {
            this.Hide();
            parterWC parterWC = new parterWC();
            parterWC.ShowDialog();
            this.Show();
        }

        private void btnParterCzerwony_Click(object sender, EventArgs e)
        {
            this.Hide();
            parterCzerwony parterCzerwony = new parterCzerwony();
            parterCzerwony.ShowDialog();
            this.Show();
        }

        private void btnParterZielony_Click(object sender, EventArgs e)
        {
            this.Hide();
            parterZielony parterZielony = new parterZielony();
            parterZielony.ShowDialog();
            this.Show();
        }

        private void btnPiwnicaOgólne_Click(object sender, EventArgs e)
        {
            this.Hide();
            piwnicaOgólne piwnicaOgólne = new piwnicaOgólne();
            piwnicaOgólne.ShowDialog();
            this.Show();
        }

        private void btnPiwnicaDługi_Click(object sender, EventArgs e)
        {
            this.Hide();
            piwnicaDługiPokój piwnicaDługiPokój = new piwnicaDługiPokój();
            piwnicaDługiPokój.ShowDialog();
            this.Show();
        }

        private void btnPiwnicaOrnaty_Click(object sender, EventArgs e)
        {
            this.Hide();
            piwnicaOrnaty piwnicaOrnaty = new piwnicaOrnaty();
            piwnicaOrnaty.ShowDialog();
            this.Show();
        }

        private void btnGarażOgólne_Click(object sender, EventArgs e)
        {
            this.Hide();
            garażOgólne garażOgólne = new garażOgólne();
            garażOgólne.ShowDialog();
            this.Show();
        }

        private void btnGarażGospodarczy_Click(object sender, EventArgs e)
        {
            this.Hide();
            garażGospodarczy garażGospodarczy = new garażGospodarczy();
            garażGospodarczy.ShowDialog();
            this.Show();
        }
    }
}
