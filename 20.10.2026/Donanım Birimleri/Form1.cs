using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace Donanım_Birimleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secim;
            secim = lsb.SelectedItem.ToString();
            if (secim =="Mouse" || secim =="Klavye" || secim == "Kamera" || secim =="Tarayıcı")
{
                lblsonuc.Text=("Bu parça, giriş birimidir.");
            }
            if (secim == "Yazıcı" || secim == "Hoparlör" || secim == "Projeksiyon")
{
                lblsonuc.Text = ("Bu parça, çıkış birimidir.");
            }
        }
    }
}
