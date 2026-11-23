using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlfabedeKac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string girilenHarf;
            girilenHarf = Convert.ToString(Boxharf.Text).ToUpper();


            switch (girilenHarf)
            {
                case "A":
                    lblson.Text = "1. harf";
                    break;
                case "B":
                    lblson.Text = "2. harf";
                    break;
                case "C":
                    lblson.Text = "3. harf";
                    break;
                case "Ç":
                    lblson.Text = "4. harf";
                    break;
                case "D":
                    lblson.Text = "5. harf";
                    break;
                case "E":
                    lblson.Text = "6. harf";
                    break;
                case "F":
                    lblson.Text = "7. harf";
                    break;
                case "G":
                    lblson.Text = "8. harf";
                    break;
                case "Ğ":
                    lblson.Text = "9. harf";
                    break;
                case "H":
                    lblson.Text = "10. harf";
                    break;
                case "I":
                    lblson.Text = "11. harf";
                    break;
                case "İ":
                    lblson.Text = "12. harf";
                    break;
                case "J":
                    lblson.Text = "13. harf";
                    break;
                case "K":
                    lblson.Text = "14. harf";
                    break;
                case "L":
                    lblson.Text = "15. harf";
                    break;
                case "M":
                    lblson.Text = "16. harf";
                    break;
                case "N":
                    lblson.Text = "17. harf";
                    break;
                case "O":
                    lblson.Text = "18. harf";
                    break;
                case "Ö":
                    lblson.Text = "19. harf";
                    break;
                case "P":
                    lblson.Text = "20. harf";
                    break;
                case "R":
                    lblson.Text = "21. harf";
                    break;
                case "S":
                    lblson.Text = "22. harf";
                    break;
                case "Ş":
                    lblson.Text = "23. harf";
                    break;
                case "T":
                    lblson.Text = "24. harf";
                    break;
                case "U":
                    lblson.Text = "25. harf";
                    break;
                case "Ü":
                    lblson.Text = "26. harf";
                    break;
                case "V":
                    lblson.Text = "27. harf";
                    break;
                case "Y":
                    lblson.Text = "28. harf";
                    break;
                case "Z":
                    lblson.Text = "29. harf";
                    break;
                default:
                    lblson.Text = "Lütfen geçerli ve tek bir harf giriniz!";
                    break;
            }
        }
    }
}
