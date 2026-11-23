namespace müşteri_aratmak
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
        private void btnAra_Click(object sender, EventArgs e)
        {
            string ad = txtAra.Text;
            for (int i =0; i < lstMusteri.Items.Count; i++)
            {
                if (lstMusteri.Items[i].ToString() == ad )
                {
                    MessageBox.Show("Müşteri Bulundu");
                }
            }
        }


    }
}
