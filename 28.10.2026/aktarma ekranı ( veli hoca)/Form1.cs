namespace aktarma_ekranı___veli_hoca_
{
    public partial class Form1 : Form
    {   
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnKyd_Click(object sender, EventArgs e)
        {
            string ad, soyad;

            ad = txtAd.Text;
            soyad = txtSoy.Text;


            lstbx1.Items.Add(ad + " " + soyad);

            txtAd.Clear();
            txtSoy.Clear();

        }

        private void btnAktar_Click(object sender, EventArgs e)
        {

            btnAktar.BackColor = Color.Transparent;

            sayac++;

            if (sayac % 2 == 1)
            {
                string deger;

                for (int i = 0; i < lstbx1.Items.Count; i++)
                {
                    deger = lstbx1.Items[i].ToString();

                    lstbx2.Items.Add(deger);

                }
                btnAktar.BackColor = Color.YellowGreen;

            }
            else
            {
                string degdi;

                for (int a = 0; a < lstbx2.Items.Count; a++)
                {
                    degdi = lstbx2.Items[a].ToString();
                    cmb.Items.Add(degdi);
                    btnAktar.BackColor = Color.DarkRed;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstbx1.Items.Clear();
            lstbx2.Items.Clear();
            cmb.Items.Clear();
        
            btnAktar.BackColor = Color.Transparent;
        }

    }
}
