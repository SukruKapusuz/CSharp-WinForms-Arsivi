namespace _2_Sayı_Karşılaştır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSor_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(txtBoxSayi1.Text);
            sayi2 = Convert.ToInt32(txtBoxSayi2.Text);
            if (sayi1 > sayi2)
            {
                MessageBox.Show("1.sayı 2.sayıdan büyüktür.");
            }
            if (sayi1 == sayi2)
            {
                MessageBox.Show("Sayılar birbirine eşittir.");
            }
            if (sayi1 < sayi2)
            {
                MessageBox.Show("2.sayı 1.sayıdan büyüktür.");
            }

        }
    }
}
