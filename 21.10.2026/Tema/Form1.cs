namespace Tema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (rdbtnkara.Checked)
            {
                this.BackColor = Color.Black;
                rdbtnkara.ForeColor = Color.White;
                rdybtnacýk.ForeColor = Color.White;
            }
            else if (rdybtnacýk.Checked)
            {
                this.BackColor = Color.White;
                rdbtnkara.ForeColor = Color.Black;
                rdybtnacýk.ForeColor = Color.Black;
            }
        }
    }
}