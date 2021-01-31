using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention(isimlendirme kuralı)
        // syntax yazım degislikleri demek
        public void Ekle(Urun urun) //Urun tipi küçük urun asagıdakı kullancagımız isimlendirme
        {
            Console.WriteLine("Tebrikler. Sepete eklendi  : " + urun.Adi);


        }
        // alttaki işlem class degildir uzun uzun yazılmıs örnek amacıyla
        public void Ekle2(string urunAdi, string aciklana, double fiyat)


        {

            Console.WriteLine("Tebrikler. Sepete eklendi  : " + urunAdi);

        }





    }
}
