namespace whileSayma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            int say = 1;
            while (say <= 10)
            {
                lstYaz.Items.Add(say);
                say++;
            }
        }
    }
}
