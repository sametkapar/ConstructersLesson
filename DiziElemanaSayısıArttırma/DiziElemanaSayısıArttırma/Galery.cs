using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziElemanaSayısıArttırma
{
    internal class Galery
    {
        public string[] araclar;

        public Galery()
        {
            araclar = new string[0];
        }

        public void AracEkle(string p_arac)
        {
            string[] gecici = new string[araclar.Length + 1];

            for (int i = 0; i < araclar.Length; i++)
            {
                gecici[i] = araclar[i];

            }
            gecici[gecici.Length - 1] = p_arac;
            araclar = gecici;

        }

        public void AracListele()
        {
            for (int i = 0; i < araclar.Length; i++)
            {
                Console.WriteLine(araclar[i]);
            }
        }
    }
}
