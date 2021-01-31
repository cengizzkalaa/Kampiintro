using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java Kursu";

            // array - dizi
            // birden fazla metini bir araya toplamak için kullanılır

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java Kursu", "Python", "C#" };
            // lengt demek elemansayısı demektir. 0 dan baslar 4 e kadar devam eder 4 dahil degil
            for (int i = 0; i < kurslar.Length; i++)
            {   // burada kursların i. elemanını yazdırmak için.
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            //dizi temelli yapıları tek tek dolaşmaya (dönmeye) yarar. ve dizilere uygulanır. oradakı kurs aliastır.

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }



            Console.WriteLine("sayfa sonu - footer");


            for (int i = 1; i < 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
