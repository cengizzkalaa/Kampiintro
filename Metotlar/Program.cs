using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { "Elma", "Karpuz" }; // buraya hangısı koyacagımızı bılemıyoruz sadece urunun string özelliklerini koyarsın o yuzden class yapıyoruz.

            Urun urun1 = new Urun();   //classın örneğidir bu. bir Urun tanımlıyoruz burada
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 }; // diziler çoğul isimlendirilir örn urunler

            //type-safe -- tip güvenli
            foreach (Urun urun in urunler) // Baştaki urun ürün tipi demek oraya var da yazabiliriz
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");

            }

            Console.WriteLine("-------------------Metotlar-------------- ");
            //encapsulation ayrı ayrı yazacagın ve düzensiz olan bir yapıyı düzene sokmak
            //instance - örnek yani class örneği

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            // class yerine böyle uzun uzun da yazılabilir ama farklı sayfalarda olucagı içni daha sonra güncellemek için işimiz çok zor gidip gidip tek tek kontrol etmen gerek.
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil Armut", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12);




        }
    }
}
