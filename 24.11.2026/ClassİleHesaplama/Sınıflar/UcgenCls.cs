using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassİleHesaplama.Sınıflar
{
    public class UcgenCls
    {
        double sonuc = 0;
        public double Alanhesapla(double a, double b)
        {
            sonuc = (a * b) / 2;
            return sonuc;
        }
        public double Cevrehesap(double a, double b, double c)
        {
            sonuc = a+b+c;
            return sonuc;
        }


    }

}
