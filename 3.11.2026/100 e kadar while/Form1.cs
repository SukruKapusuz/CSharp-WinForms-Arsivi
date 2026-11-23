namespace _100_e_kadar_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnyaz_Click(object sender, EventArgs e)
        {
            int dongu_say = 1;
            int toplam = 0;

            while (toplam <= 1000)
            {
                toplam = toplam + dongu_say;
                dongu_say += 1;
                lstyaz.Items.Add(toplam);
            }
            MessageBox.Show("döngü toplam " + dongu_say.ToString() + "kez çalýþtý");



        }

    }
}
