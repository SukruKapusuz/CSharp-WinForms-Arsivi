namespace girisEkranı___Soru1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSor_Click(object sender, EventArgs e)
        {
            string ad, sifre;
            ad = txtAd.Text;
            sifre = txtSifre.Text;

            if (ad == "Teknopark" & sifre == "12345")
            {
                MessageBox.Show("Doğrulama Başarılı");

            }
            else if (ad != "Teknopark" & sifre == "12345")
            {
                MessageBox.Show("Kullanıcı Adı Hatalı");
            }
            else
            {
                MessageBox.Show("ikisi de hatalı");
            }
        }
    }
}
