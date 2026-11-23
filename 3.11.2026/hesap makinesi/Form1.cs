namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 10)
            {
                int b = 1;
                while (b <= 10)
                {
                    int deger = i * b;
                    lsthesap.Items.Add(i + "x" + b + "=" + deger);
                    b++;
                }
                lsthesap.Items.Add("--------------------");
                i++;
            }
        }
    }
}

