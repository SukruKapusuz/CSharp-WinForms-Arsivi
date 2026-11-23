using System;

namespace classDenemesi
{

    public class Dikdotgen
    {
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }

        public int AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }

        public int CevreHesapla()
        {
            return 2 * (KisaKenar + UzunKenar);
        }
    }
}
