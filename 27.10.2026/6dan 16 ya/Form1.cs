namespace _6dan_16_ya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 6; i <= 16; i++)
            {
                comboBox1.Items.Add(i);

            }
        }
    }
}
