namespace Tekmi_Çiftmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = Convert.ToInt32(txtBoxSayi.Text);
            if (sayi1 == 0)
            {
                MessageBox.Show("Sayınız 0 dır");

            }
            if (sayi1 % 2 == 1)
            {
                MessageBox.Show("Sayınız tektir");

            }
            if (sayi1 % 2 == 0)
            {
                MessageBox.Show("Sayınız çifttir");

            }

        }
    }
}
