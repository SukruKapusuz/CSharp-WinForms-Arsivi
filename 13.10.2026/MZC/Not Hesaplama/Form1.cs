using System;
using System.Windows.Forms;

namespace Not_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            double not1 = Convert.ToDouble(txtBoxNot1.Text);
            double not2 = Convert.ToDouble(txtBoxNot2.Text);

            
            double ortalama = (not1 + not2) / 2;
            lblSonuc.Text = ortalama.ToString();
        }
    }
}