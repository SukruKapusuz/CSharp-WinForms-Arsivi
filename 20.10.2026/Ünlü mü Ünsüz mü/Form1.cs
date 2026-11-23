namespace Ünlü_mü_Ünsüz_mü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSor_Click(object sender, EventArgs e)
        {
            string girilenHarf;
            girilenHarf = Convert.ToString(cmbBox.Text);


            switch (girilenHarf)
            {
                case "A":
                    lblson.Text = "Sesli Harf";
                    break;
                case "B":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "C":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "Ç":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "D":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "E":
                    lblson.Text = "Sesli Harf";
                    break;
                case "F":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "G":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "Ğ":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "H":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "I":
                    lblson.Text = "Sesli Harf";
                    break;
                case "İ":
                    lblson.Text = "Sesli Harf";
                    break;
                case "J":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "K":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "L":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "M":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "N":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "O":
                    lblson.Text = "Sesli Harf";
                    break;
                case "Ö":
                    lblson.Text = "Sesli Harf";
                    break;
                case "P":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "R":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "S":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "Ş":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "T":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "U":
                    lblson.Text = "Sesli Harf";
                    break;
                case "Ü":
                    lblson.Text = "Sesli Harf";
                    break;
                case "V":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "Y":
                    lblson.Text = "Sessiz Harf";
                    break;
                case "Z":
                    lblson.Text = "Sessiz Harf";
                    break;
                default:
                    lblson.Text = "Lütfen geçerli ve tek bir harf giriniz!";
                    break;
            }
        }
    }
}