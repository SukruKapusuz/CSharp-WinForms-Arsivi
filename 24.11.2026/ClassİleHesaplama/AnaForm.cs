using ClassİleHesaplama.formlar;
using ClassİleHesaplama.Formlar;

namespace ClassİleHesaplama
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnDikdortgen_Click(object sender, EventArgs e)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.Show();
            this.Hide();
        }

        private void btnUcgen_Click(object sender, EventArgs e)
        {
            UcGenFrm ucgenfrm = new UcGenFrm();
            ucgenfrm.Show();
            this.Hide();
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            kareform kareform = new kareform();
            kareform.Show();
            this.Hide();
        }
    }
}
