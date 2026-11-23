using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kart_Çevirme_Oyunu
{
    public partial class Form1 : Form
    {
        
        int oyunDurumu = 1; 

        Button ilkButon;
        Button ikinciButon;
        Color ilkRenk;
        Color ikinciRenk;

        Color renk1, renk2, renk3, renk4;
        Color renk5, renk6, renk7, renk8;
        Color renk9, renk10, renk11, renk12;
        Color renk13, renk14, renk15, renk17;

        public Form1()
        {
            InitializeComponent();

            
            renk1 = btn1.BackColor;
            renk2 = btn2.BackColor;
            renk3 = btn3.BackColor;
            renk4 = btn4.BackColor;
            renk5 = btn5.BackColor;
            renk6 = btn6.BackColor;
            renk7 = btn7.BackColor;
            renk8 = btn8.BackColor;
            renk9 = btn9.BackColor;
            renk10 = btn10.BackColor;
            renk11 = btn11.BackColor;
            renk12 = btn12.BackColor;
            renk13 = btn13.BackColor;
            renk14 = btn14.BackColor;
            renk15 = btn15.BackColor;
            renk17 = btn17.BackColor;

            
            btn1.BackColor = Color.LightGray;
            btn2.BackColor = Color.LightGray;
            btn3.BackColor = Color.LightGray;
            btn4.BackColor = Color.LightGray;
            btn5.BackColor = Color.LightGray;
            btn6.BackColor = Color.LightGray;
            btn7.BackColor = Color.LightGray;
            btn8.BackColor = Color.LightGray;
            btn9.BackColor = Color.LightGray;
            btn10.BackColor = Color.LightGray;
            btn11.BackColor = Color.LightGray;
            btn12.BackColor = Color.LightGray;
            btn13.BackColor = Color.LightGray;
            btn14.BackColor = Color.LightGray;
            btn15.BackColor = Color.LightGray;
            btn17.BackColor = Color.LightGray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn1_Click(object sender, EventArgs e) { Oyun(btn1, renk1); }
        private void btn2_Click(object sender, EventArgs e) { Oyun(btn2, renk2); }
        private void btn3_Click(object sender, EventArgs e) { Oyun(btn3, renk3); }
        private void btn4_Click(object sender, EventArgs e) { Oyun(btn4, renk4); }
        private void btn5_Click(object sender, EventArgs e) { Oyun(btn5, renk5); }
        private void btn6_Click(object sender, EventArgs e) { Oyun(btn6, renk6); }
        private void btn7_Click(object sender, EventArgs e) { Oyun(btn7, renk7); }
        private void btn8_Click(object sender, EventArgs e) { Oyun(btn8, renk8); }
        private void btn9_Click(object sender, EventArgs e) { Oyun(btn9, renk9); }
        private void btn10_Click(object sender, EventArgs e) { Oyun(btn10, renk10); }
        private void btn11_Click(object sender, EventArgs e) { Oyun(btn11, renk11); }
        private void btn12_Click(object sender, EventArgs e) { Oyun(btn12, renk12); }
        private void btn13_Click(object sender, EventArgs e) { Oyun(btn13, renk13); }
        private void btn14_Click(object sender, EventArgs e) { Oyun(btn14, renk14); }
        private void btn15_Click(object sender, EventArgs e) { Oyun(btn15, renk15); }
        private void btn17_Click(object sender, EventArgs e) { Oyun(btn17, renk17); }

        private void Oyun(Button tiklanan, Color renk)
        {
            
            if (tiklanan.Visible == false)
            {
                return;
            }

            
            if (tiklanan.BackColor != Color.LightGray)
            {
                return;
            }

            
            if (oyunDurumu == 3)
            {
               
                ilkButon.BackColor = Color.LightGray;
                ikinciButon.BackColor = Color.LightGray;

                
                oyunDurumu = 1;
            }
            tiklanan.BackColor = renk;
            Application.DoEvents();

          

            if (oyunDurumu == 1)
            {
               
                ilkButon = tiklanan;
                ilkRenk = renk;

                oyunDurumu = 2; 
            }
            else if (oyunDurumu == 2)
            {
                
                ikinciButon = tiklanan;
                ikinciRenk = renk;

                
                if (ilkRenk == ikinciRenk)
                {
                    
                    ilkButon.Visible = false;
                    ikinciButon.Visible = false;

                    
                    oyunDurumu = 1;
                }
                else
                {
                    
                    oyunDurumu = 3;
                }
            }
        }
    }
}