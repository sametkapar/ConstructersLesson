using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziElemanaSayısıArttırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Dizini eleman sayısının içindeki verileri kaybetmeden arttırmak MÜMKÜN DEĞİLDİR

            #endregion

            #region Bakalım Nasıl Oluyor

            //string[] isimler = new string[3];
            //isimler[0] = "Murtaza";
            //isimler[1] = "Şuayip";
            //isimler[2] = "John";



            //isimler = new string[4];
            //isimler[3] = "Jane";

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            #endregion

            #region Peki Ne Yapmalıyız?

            //string[] katilimcilar = new string[0];

            //string secenek = "e";

            //while (secenek == "e")
            //{
            //    string[] gecici = new string[katilimcilar.Length + 1];

            //    //Dizi Kopyalama
            //    for (int i = 0; i < katilimcilar.Length; i++)
            //    {
            //        gecici[i] = katilimcilar[i];
            //    }
            //    Console.WriteLine("Lütfen Katılımcı Adını Giriniz");
            //    string isim = Console.ReadLine();


            //    gecici[gecici.Length - 1] = isim;

            //    katilimcilar = gecici;

            //    Console.WriteLine("Katılımcı eklemeye devam etmek istermisiniz?");
            //    secenek = Console.ReadLine();
            //}


            #endregion

            #region Galeri Uygulaması

            //Galery otoSam = new Galery();
            //string secenek = "e";
            //while (secenek == "e")
            //{
            //    Console.WriteLine("Araç adını giriniz");
            //    string isim = Console.ReadLine();
            //    otoSam.AracEkle(isim);

            //    Console.WriteLine("Araç eklemeye devam edilsin mi?e/h");
            //    secenek = Console.ReadLine();
            //}

            #endregion


            #region Konferans uygulaması

            Konferans k = new Konferans();

            string devam = "e";


            while(devam == "e")
            {
                Insan kisi = new Insan();
                Console.WriteLine("Katlımıcı adı = ");
                kisi.isim = Console.ReadLine();
                Console.WriteLine("Katlımcı soy adı = ");
                kisi.soyisim = Console.ReadLine();

                k.KatilimciEkle(kisi);

                Console.WriteLine("Katılımcı eklemeye devam edilsin mi?e/h");
                devam = Console.ReadLine();
                Console.Clear ();

            }

            k.KatilimciListele();
            #endregion


            #region Ödevler
            //Sınav oluştur - Sınavı başlat
            //Kütüphane oluştur 2ye bas kitapları listele 3e basınca türe göre
            //Ürün-ad,fiyat menü listele stok miktarı. stok miktarı 0 olanlar listelenmeyecek. Ürün satın almada alınan miktar stoktan düşecek.

            #endregion
        }
    }
}
