namespace Lamba_ve_kombi_sorgula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstBoxRapor.Items.Clear();
            if (checkboxKombi.Checked)
            {
                lstBoxRapor.Items.Add("kombi açýk");
            }
            else
            {
                lstBoxRapor.Items.Add("kombi kapalý");
            }
            if (checkboxÝsik.Checked)
            {
                lstBoxRapor.Items.Add("ýþýk açýk");
            }
            else
            {
                lstBoxRapor.Items.Add ("ýþýk kapalý");
            }
        }
    }
}
