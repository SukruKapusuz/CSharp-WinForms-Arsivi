using System.Windows.Forms;

namespace _7_kez_yaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            for (int i = 0; i < 7; i++)
            {
                list.Items.Add("Biliþim Teknolojileri");
            }
        }
    }
}