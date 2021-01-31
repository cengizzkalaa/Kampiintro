using System;

namespace ikinciGunodeV6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunAdi = "Çamaşır Makinası";
            product1.Id = 1001;
            product1.UrunFiyati = 2500;

            Product product2 = new Product();
            product2.UrunAdi = "Bulaşık Makinası";
            product2.Id = 1002;
            product2.UrunFiyati = 1200;

            Product product3 = new Product();
            product3.UrunAdi = "Buzdolabı       ";
            product3.Id = 1003;
            product3.UrunFiyati = 3800;

            Product product4 = new Product();
            product4.UrunAdi = "Televizyon      ";
            product4.Id = 1004;
            product4.UrunFiyati = 4800;
            Product[] products = new Product[]
            {
                product1,product2,product3,product4
            };
            Console.WriteLine("-------for döngüsü ile sıralama -----------");
            Console.WriteLine("Ürün Adı   /      Id    /Fiyatı");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].UrunAdi + " " + products[i].Id + "  " + products[i].UrunFiyati + " TL");
            }
            Console.WriteLine("-------foreach döngüsü ile sıralama -----------");

            Console.WriteLine("Ürün Adı   /      Id    /Fiyatı");

            // buradaki i takma isim alias
            foreach (var i in products)
            {
                Console.WriteLine(i.UrunAdi + " " + i.Id + "  " + i.UrunFiyati + " TL");
            }
            Console.WriteLine("-------While döngüsü ile sıralama -----------");
            Console.WriteLine("Ürün Adı   /      Id    /Fiyatı");
            int s = 0;
            while (s < products.Length)
            {
                Console.WriteLine(products[s].UrunAdi + " " + products[s].Id + "  " + products[s].UrunFiyati + " TL");
                s = s + 1;
            }


        }
    }


    class Product
    {
        public string UrunAdi { get; set; }
        public int Id { get; set; }
        public int UrunFiyati { get; set; }

    }
}


