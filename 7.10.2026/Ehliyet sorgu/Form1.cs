namespace Ehliyet_sorgu
{
    public partial class Ehliyet_Sorgu : Form
    {
        public Ehliyet_Sorgu()
        {
            InitializeComponent();
        }

        private void btnsor_Click(object sender, EventArgs e)
        {
            byte yas;
            yas = Convert.ToByte(txtboxyas.Text);
            if (yas == 18)
            {
                lblsonuc.Text = "Ehliyet almaya yaþýnýz uygun";
            }
            if (yas > 18) 
            {
                lblsonuc.Text = "Ehliyet almaya yaþýnýz uygun";
            }
            if (yas < 18)
            {
                lblsonuc.Text = "Ehliyet almaya yaþýnýz uygun deðil";
            }
            if (yas >= 16)
            {
                lbl_motor.Text = "Yaþýnýz motor ehliyeti almaya uygun";
            }

            
          




        }
    }
}
