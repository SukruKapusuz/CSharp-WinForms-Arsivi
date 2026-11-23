namespace Sayaç
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {   
            int sayi;
            sayi = Convert.ToInt32(txtSayi.Text);


            
            

            sayi = sayi-1 ;
            txtSayi.Text = sayi.ToString();
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(txtSayi.Text);
            sayi = sayi + 1;
            txtSayi.Text =  sayi.ToString() ;

        }
    }
}
