using System;
using System.Collections.Generic; // Listi kullanmak için listin yanına gelen ampulden burayı okeyliyoruz

namespace Lpşels
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Cengiz","Rezan","Leyla","Hıdır" }; // array sadece bu sınırlar ıcerısındedır.
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];  // burada heapte yeni adrese 5 kişilik yer oluşturduk fakat sadece 4. kişiyi tanımladık diğerleri boş. İşte bu yüzden
            //isimler[4] = "Sevim";     // array degil de koleksiyonları kullanırız. Bu şekilde işlem çalışır fakat 0 1 2 3 5 elamanlar ekrana yazmaz. Çünkü tanımlı degil
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);



            List<string> isimler2 = new List<string> { "Cengiz", "Rezan", "Leyla", "Hıdır" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Sevim");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            // koleksiyonlarda değerleri kaybetmemizi engelleyen bir yapı var. Arraylarde öyle degildir.


        }
    }
}
