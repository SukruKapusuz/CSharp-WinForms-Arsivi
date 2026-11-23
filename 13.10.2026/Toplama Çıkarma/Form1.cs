namespace Toplama_Çıkarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger1 = Convert.ToInt32(textBox1.Text);
            int deger2 = Convert.ToInt32(textBox2.Text);
            int sonuc;
            if (btnTopla.Checked == true)
            {
                lblson.Text = (deger1 + deger2).ToString();
            }
            if (btnCıkar.Checked == true)
            {
                lblson.Text = (deger1 - deger2).ToString();
            }
            if (btnBöl.Checked == true)
            {
                lblson.Text = (deger1 / deger2).ToString();
            }
            if (btnCarp.Checked == true)
            {
                lblson.Text = (deger1 * deger2).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
