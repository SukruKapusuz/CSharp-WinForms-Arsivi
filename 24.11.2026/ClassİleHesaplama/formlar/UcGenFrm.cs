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

namespace ClassİleHesaplama.formlar
{
    public partial class UcGenFrm : Form
    {
        public UcGenFrm()
        {
            InitializeComponent();
        }

        private void UcGenFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaForm anaform = new AnaForm();
            anaform.Show();
        }

        private void UcGenFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnAlan_Click(object sender, EventArgs e)
        {
            double tab = Convert.ToDouble(txtTaban.Text);
            double yuk = Convert.ToDouble(txtTaban.Text);

            UcgenCls ucgenCls = new UcgenCls();
            lblAlan.Text = ucgenCls.Alanhesapla(tab, yuk).ToString();


        }

        private void btnCevre_Click(object sender, EventArgs e)
        {
            double a1 = Convert.ToDouble(txtKnr1.Text);
            double a2 = Convert.ToDouble(txtKnr2.Text);
            double a3 = Convert.ToDouble(txtKnr3.Text);
            UcgenCls ucgenCls = new UcgenCls();
            lblCevre.Text = ucgenCls.Cevrehesap(a1,a2,a3).ToString();
        }
    }
}
