using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {   //Cengiz Kala -Gercek Müsteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Cengiz";
            musteri1.Soyadi = "Kala";
            musteri1.TcNo = "12345678910";

            //BKodlama.io - Tuzel Musteri

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            // Gerçek Müşteri - Tüzel Müşteri aslında ikiside müşteri sırf birbirine benziyor diye birbirinin yerine kullanılamaz!. İkisi farklı müşteri tipleridir.
            // SOLID

            Musteri musteri3 = new GercekMusteri();   // Musteri,  hem Gerçek hem de Tuzel Musterinin referansını tutabiliyor.
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);







        }
    }
}
