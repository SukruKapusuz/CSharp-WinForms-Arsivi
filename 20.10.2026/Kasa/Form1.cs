namespace Kasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnöde_Click(object sender, EventArgs e)
        {
            double tutar;
            tutar = Convert.ToDouble(txtgir.Text);
            if (yuzde5_1.Checked == true || Yuzde5_2.Checked == true)
            {
                tutar = tutar + (tutar * 0.05);
            }
            if (Yuzde10_1.Checked == true || Yuzde10_2.Checked == true)
            {
                tutar = tutar + (tutar * 0.10);
            }
            
            lblson.Text = ("Ödenecek Toplam Tutar:" + "  " + tutar.ToString() + "  " + "TL");
        }
    }
}
