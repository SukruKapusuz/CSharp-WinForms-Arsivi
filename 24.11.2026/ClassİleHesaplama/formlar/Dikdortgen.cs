using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassİleHesaplama.Sınıflar;

namespace ClassİleHesaplama.Formlar
{
    public partial class Dikdortgen : Form
    {
        public Dikdortgen()
        {
            InitializeComponent();
        }

        private void Dikdortgen_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaForm anaform = new AnaForm();
            anaform.Show();
        }

        private void Dikdortgen_Load(object sender, EventArgs e)
        {

        }

        private void btnCevre_Click(object sender, EventArgs e)
        {
            int uk, kk;
            uk = Convert.ToInt16(txtUzun.Text);
            kk = Convert.ToInt16(txtKisa.Text);


            DikdortgenCls dikdortgenCls = new DikdortgenCls();

            lblAlan.Text=dikdortgenCls.AlanHesapla(uk, kk).ToString();
            lblCevre.Text = dikdortgenCls.CevreHesapla(uk, kk).ToString();
        }

        private void btnAlan_Click(object sender, EventArgs e)
        {



            int uk, kk;
            uk = Convert.ToInt16(txtUzun.Text);
            kk = Convert.ToInt16(txtKisa.Text);

            DikdortgenCls dikdortgenCls = new DikdortgenCls();

            lblAlan.Text=dikdortgenCls.AlanHesapla(uk, kk).ToString();

        }
    }
}
