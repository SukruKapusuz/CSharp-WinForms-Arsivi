namespace Sayı_kaç_büyük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnKontrol_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);

            if (sayi1 > sayi2)
            {
                MessageBox.Show("SAYI 1 Sayı 2 den BÜYÜKTÜR");
            }

            if (sayi2 > sayi1)
            {
                MessageBox.Show("SAYI 2 Sayı 1 den BÜYÜKTÜR.");
            }

            if (sayi1 == sayi2)
            {
                MessageBox.Show("!!2 sayıda birbirine eşittir!!");
            }

        }
    }
}
