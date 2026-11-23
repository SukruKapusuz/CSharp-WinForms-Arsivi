namespace _7_defa_yazdır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstyaz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                lstyaz.Items.Add("Bilişim Teknolojileri");
            }
        }
    }
}
