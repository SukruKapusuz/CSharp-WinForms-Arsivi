namespace Sayının_Karesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;

            
            sayi = Convert.ToInt32(txtSayi);
            sonuc = sayi * sayi;
            lblkaresi.Text = sonuc.ToString();

        }
    }
}
