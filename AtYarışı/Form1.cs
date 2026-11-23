using System.Windows.Forms;

namespace AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNormal1_Click(object sender, EventArgs e)
        {
            at1.Left = at1.Left + 10;
        }

        private void btnHizli1_Click(object sender, EventArgs e)
        {
            at1.Left = at1.Left + 25;
        }

        private void btnNormal2_Click(object sender, EventArgs e)
        {
            at2.Left = at2.Left + 10;
        }

        private void btnHizli2_Click(object sender, EventArgs e)
        {
            at2.Left = at2.Left + 25;
        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
          
            at1.Location = new Point(14, 40);  
            at2.Location = new Point(14, 170); 
        }
    }
}

