namespace _5_in_katı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 100; i <= 150; i = i + 5)
            {
                comboBox1.Items.Add(i);
            }
        }
    }
}
