using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetotlarConstructors
{
    internal class Kitap
    {
        private string isim;
        private string yazar;
        public string yayinEvi;
        public double fiyat;

        public Kitap(string isim, string yazar)
        {
            this.isim = isim;
            this.yazar = yazar;

        }
        public string Yazdir()
        {
            return "İsim = " + isim + "\nYazar = " + yazar + "\nYayın Evi = " + yayinEvi + "\nFiyat = " + fiyat + " TL";
        }


    }
}
