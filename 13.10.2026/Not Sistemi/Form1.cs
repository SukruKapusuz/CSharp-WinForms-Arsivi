using System.Windows.Forms;

namespace Not_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSon_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(txtBoxNot.Text);
            if (sayi < 0)
            {
                lblson.Text=("0’dan büyük bir sayý giriniz!");
            }
            else if (sayi < 25)
            {
                lblson.Text = ( sayi +" olan "+ "Notunuzun derecesi 0");
            }
            else if (sayi < 45)
            {
                lblson.Text = (sayi + " olan " + "Notunuzun derecesi 1");
            }
            else if (sayi < 55)
            {
                lblson.Text = (sayi + " olan " + "Notunuzun derecesi 2");
            }
            else if (sayi < 70)
            {
                lblson.Text = (sayi + " olan " + "Notunuzun derecesi 3");
            }
            else if (sayi < 85)
            {
                lblson.Text = (sayi + " olan " + "Notunuzun derecesi 4");
            }
            else if (sayi <= 100)
            {
                lblson.Text = (sayi + " olan " + "Notunuzun derecesi 5");
            }
            else
            {
                lblson.Text = ("Hatalý giriþ yaptýnýz!");
            }
        }
    }
}
