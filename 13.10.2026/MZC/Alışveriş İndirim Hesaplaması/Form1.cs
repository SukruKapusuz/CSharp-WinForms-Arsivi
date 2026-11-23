using System;
using System.Windows.Forms;

namespace Alışveriş_İndirim_Hesaplaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesapsonuc_Enter(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // 1. GİRDİ
            string girilenMetin = textBox1.Text.Replace('.', ',');
            double tutar = Convert.ToDouble(girilenMetin);

            // 2. İŞLEM (İndirimleri hesapla)
            double ogrenciIndirimi = chcBoxOgrenci.Checked ? tutar * 0.10 : 0;
            double sadakatIndirimi = chcBoxSadaka.Checked ? tutar * 0.10 : 0;
            double toplamIndirim = ogrenciIndirimi + sadakatIndirimi;
            double netTutar = tutar - toplamIndirim;

            // 3. ÇIKTI (Sağ alttaki detayları doldurma bölümü)
            // Tasarımda belirlediğin isimlere göre sağ alt kısmı besliyoruz
            lblNetTutar.Text = netTutar.ToString("N2") + " TL";

            brutTutar.Text = "Brüt Tutar: " + tutar.ToString("N2") + " TL";
            lblogrenciİndir.Text = "-Öğrenci İndirimi: " + ogrenciIndirimi.ToString("N2") + " TL";
            lblSadakatİndir.Text = "-Sadakat kart İndirimi: " + sadakatIndirimi.ToString("N2") + " TL";
            label9.Text = "Toplam İndirim: " + toplamIndirim.ToString("N2") + " TL";

        }
    }
}