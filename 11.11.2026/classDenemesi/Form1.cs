using System;
using System.Windows.Forms;

namespace classDenemesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            
            Dikdotgen d = new Dikdotgen();

            
            d.KisaKenar = Convert.ToInt32(txtKisa.Text);
            d.UzunKenar = Convert.ToInt32(txtUzun.Text);

            
            int alan = d.AlanHesapla();
            int cevre = d.CevreHesapla();

            MessageBox.Show($"Dikdörtgenin Alaný: {alan}\nDikdörtgenin Çevresi: {cevre}", "Hesaplama Sonucu");
        }
    }
}
