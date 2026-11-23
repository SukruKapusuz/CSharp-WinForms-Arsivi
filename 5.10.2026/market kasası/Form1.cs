using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_kasası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pizzaFiyat = 150;
            int icecekFiyat = 40;
            int tatliFiyat = 60;

            int pizzaAdet = Convert.ToInt32(textBox1.Text);
            int icecekAdet = Convert.ToInt32(textBox2.Text);
            int tatliAdet = Convert.ToInt32(textBox3.Text);

            int pizzaToplam = pizzaFiyat * pizzaAdet;
            int icecekToplam = icecekFiyat * icecekAdet;
            int tatliToplam = tatliFiyat * tatliAdet;

            int genelToplam = pizzaToplam + icecekToplam + tatliToplam;

            label5.Text = genelToplam.ToString() + " TL";
        }
    }
}
