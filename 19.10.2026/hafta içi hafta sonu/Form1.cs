using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta_içi_hafta_sonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsorgula_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(DateTime.Now.DayOfWeek);
            switch (gun)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    lblsonuc.Text=("Hafta içi");
                    break;
                case 6:
                case 0:
                    lblsonuc.Text = ("Hafta sonu");
                    break;
                default:
                    lblsonuc.Text = ("Hata oluştu.");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
