namespace Sıcaklık
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSon.Text = "";
            int derece;
            derece = Convert.ToInt32(txtBoxDerece.Text);
            if (derece < 10) { lblSon.Text = "Hava Soğuk"; }
            else if (derece > 10 & derece < 25) { lblSon.Text = "Hava hafif sıcak"; }
            else if (derece >= 25) { lblSon.Text = "Hava sıcak"; }
            else { lblSon.Text = "hatalı değer girdiniz"; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
