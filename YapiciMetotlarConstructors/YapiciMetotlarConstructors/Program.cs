using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetotlarConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Tanımlama

            //Sınıfın nesnesi oluşturulduğunda otomatik olarak çalışan sınıftır.
            //Yapıcı metotların geri dönüş türü olmaz
            //Yapıcı metot adı sınıfın adıyla aynı olmalıdır
            //YAPICI METOT KULLANIMI ZORUNLU DEĞİLDİR
            //Yapıcı metotlar parametre alabilirler
            //Amacı nesneyi kullanıma hazırlamaktır


            #endregion

            #region Kullanım
            //Insan ins =new Insan();

            //Personel p =new Personel("Samet", "Kapar");
            //Console.WriteLine("Personel Adı= " + p.isim + "Personel Soyadı"+ p.soyisim);

            //Personel p2 = new Personel("Mevlüt", "Koyuncu");
            //p2.departman = "Game Developer";
            //Console.WriteLine("Personel Adı = " + p2.isim +", "+"Personel Soyadı = " + p2.soyisim);
            //Console.WriteLine("Departman = " + p2.departman);

            #endregion

            #region Kitap ile Readonly alanlar

            Kitap k = new Kitap("Monter Cristo Kontu", "Alexandre Dumas");
            k.yayinEvi = "Metis";
            k.fiyat = 60;

            Console.WriteLine(k.Yazdir());
            Console.WriteLine("-------------------");
            k.fiyat = 120;
            Console.WriteLine(k.Yazdir());


            #endregion


        }
    }
}
