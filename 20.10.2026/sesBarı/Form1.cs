namespace sesBarı
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {      
            
            int ses = trackBar1.Value;
            lblseviye.Text = ses.ToString();
            if (ses == 0)
            {
                lblcıktı.Text = "Ses Yok";
                lblcıktı.ForeColor = Color.Black;
               
            }
            else if (ses > 0 && ses <= 10)
            {
                lblcıktı.Text = "Normal Ses Seviyesi";
                lblcıktı.ForeColor = Color.Green;
            }
            else if (ses >= 11)
            {
                lblcıktı.Text = "Yüksek Ses Seviyesi";
                lblcıktı.ForeColor = Color.Red;
            }
        }
    }
}