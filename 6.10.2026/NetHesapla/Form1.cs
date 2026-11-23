namespace NetHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            double TurkceDogru, MatematikDogru;
            double TurkceYanlis, MatematikYanlis;
            double TurkceNet, MatematikNet;

            TurkceDogru = Convert.ToDouble(txtTurkceDogru.Text);
            TurkceYanlis = Convert.ToDouble(txtTurkceYanlis.Text);

            TurkceNet = (TurkceDogru - (TurkceYanlis / 4));
            txtTurkceNet.Text = TurkceNet.ToString();

            MatematikDogru = Convert.ToDouble(txtMatematikDogru.Text);
            
            MatematikYanlis = Convert.ToDouble(txtMatematikYanlis.Text);
            MatematikNet = (MatematikDogru - (MatematikYanlis / 4));
            txtMatematikNet.Text = MatematikNet.ToString();



        }
    }
}
