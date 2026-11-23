namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Topla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(txt1.Text);
            sayi2 = Convert.ToInt32(txt2.Text);
            toplam = sayi1 + sayi2;
            sonuc.Text = toplam.ToString();



            lblsayý1.Text = "Toplanan :";
            lbl2.Text = "Toplanan :";
            label3.Text = "Toplam";


        }

        private void çýkar_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, cýktý;
            sayi1 = Convert.ToInt32(txt1.Text);
            sayi2 = Convert.ToInt32(txt2.Text);
            cýktý = sayi1 - sayi2;
            sonuc.Text = cýktý.ToString();



            lblsayý1.Text = "çýkýlan :";
            lbl2.Text = "çýkarýlan :";
            label3.Text = "Fark";


        }

        private void carp_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, carpým;
            sayi1 = Convert.ToInt32(txt1.Text);
            sayi2 = Convert.ToInt32(txt2.Text);
            carpým = sayi1 * sayi2;
            sonuc.Text = carpým.ToString();


            lblsayý1.Text = "Çarpan :";
            lbl2.Text = "Çarpýlan :";
            label3.Text = "Çarpým";

        }

        private void böl_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, böl;
            sayi1 = Convert.ToInt32(txt1.Text);
            sayi2 = Convert.ToInt32(txt2.Text);
            böl = sayi1 / sayi2;
            sonuc.Text = böl.ToString();


            lblsayý1.Text = "bölünen :";
            lbl2.Text = "Bölen :";
            label3.Text = "Bölüm";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblsayý1.Text = "Sayý 1:";
            lbl2.Text = "Sayý 2:";
            label3.Text = "Sonuç";
            txt1.Text =  "" ;
            txt2.Text =  "" ;
        }
    }
}
