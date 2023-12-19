using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GECTİ_KALDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            float yazili1, yazili2, ortalama;
            yazili1 = Convert.ToSingle(txtYazili1.Text);
            yazili2 = Convert.ToSingle(txtYazili2.Text);
            ortalama = (yazili2 + yazili1) / 2;

            lblOrtalama.Text = "Ortalam: " + ortalama.ToString();

            if (ortalama >= 50)
            {
                lblDurum.Text = "Durum:  GEÇTİ";
                lblDurum.ForeColor = Color.Green;
            }
            else
            {
                lblDurum.Text = "Durum:  KALDI";
                lblDurum.ForeColor = Color.Red;
            }

        }









    
    }
}
