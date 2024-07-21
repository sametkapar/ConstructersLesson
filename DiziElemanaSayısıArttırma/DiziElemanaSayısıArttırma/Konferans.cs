using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziElemanaSayısıArttırma
{
    internal class Konferans
    {
        public Insan[] katilimcilar;

        public Konferans()
        {
            katilimcilar = new Insan[0];
        }

        public void KatilimciEkle(Insan ins)
        {
            Insan[] gecici =new Insan[katilimcilar.Length+1];
            Array.Copy(katilimcilar,gecici,katilimcilar.Length);

            gecici[gecici.Length-1] = ins;
            katilimcilar = gecici;

        }
        public void KatilimciListele() 
        {
            for (int i = 0; i < katilimcilar.Length; i++)
            {
                Console.WriteLine($"{i+1}) {katilimcilar[i].isim} {katilimcilar[i].soyisim}");
            }
        }
    }
}
