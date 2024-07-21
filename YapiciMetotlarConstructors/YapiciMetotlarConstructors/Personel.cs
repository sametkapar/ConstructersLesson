using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetotlarConstructors
{
    internal class Personel
    {
        public string isim;
        public string soyisim;
        public string departman;

        public Personel(string p_isim, string p_soyisim)
        {
            isim = p_isim;
            soyisim = p_soyisim;
        }
    }
}
