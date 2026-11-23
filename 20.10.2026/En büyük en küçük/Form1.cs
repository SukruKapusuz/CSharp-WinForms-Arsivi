namespace En_büyük_en_küçük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnBuyuk_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3;
            sayi1 = Convert.ToInt32(txtBox1.Text);
            sayi2 = Convert.ToInt32(txtBox2.Text);
            sayi3 = Convert.ToInt32(txtBox3.Text);

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                lblEnBuyuk.Text = "Sayı 1 EN büyük";
            }
            else if (sayi1 < sayi2 && sayi2 > sayi3)
            {
                lblEnBuyuk.Text= "Sayı 2 En büyük";
            }
            else
            {
                lblEnBuyuk.Text = " Sayı 3 En büyük";
            }

        }

        private void btnKucuk_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3;
            sayi1 = Convert.ToInt32(txtBox1.Text);
            sayi2 = Convert.ToInt32(txtBox2.Text);
            sayi3 = Convert.ToInt32(txtBox3.Text);

            if (sayi1 < sayi2 && sayi1 < sayi3)
            {
                lblEnKucuk.Text = "Sayı 1 EN KÜÇÜK";
            }
            else if (sayi1 > sayi2 && sayi2 < sayi3)
            {
                lblEnKucuk.Text = "Sayı 2 En Küçük";
            }
            else
            {
                lblEnKucuk.Text = "Sayı 3 En Küçük";
            }
        }
    }
}
