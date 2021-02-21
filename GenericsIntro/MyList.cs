using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro // List yokmus gibi nasıl yazarız? Onu yapıyoruz burada.
{
    class MyList<T>  //T type dan geliyor.
    {

        T[] items;    // class ın butun operasyonlarının yani metodlarının erişebilecegi bi dizi tanımlıyoruz burada. T tipinde items tanımladık çünkü string de olabilir intte olabilir.
        //contsructor denir alttaki bloğa
        public MyList()  // burası bir metottur operasyon ctor yaz tab tab
        {

            items = new T[0];  // artık elimde 0 elemanlı bir dizi var ve asagıda olduugu gibi artık diziye eleman ekleyebiliriz.

        }
        public void Add(T item) //ben sana t olarak ne verirsem o an  ne istersem int string farketmez o olur aynı zamanda burası bir operasyon yani metotdur
        {
            T[] tempArray = items;  //Gecici dizinin referansı itemsın referansı demek. Elemanlar kaybolmucak sabitlenicek. Çünkü newledigimizde yeni ref no alıyor diger elemanlar kayboluyor. Bu yüzden bu işlemi yapıyoruz.
            items = new T[items.Length + 1];  //dizinin elaman sayısını 1 arttır çünkü yukarıda gördügün gibi 0 elemanlıydı
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // temparray e verdigimiz gecici elemanları sırasıyla kendi üzerimize geri alıyoruz ve items bütün elemanlarına tekrar kavuşur.

            }

            items[items.Length - 1] = item; // aslında eklenmek istenen elemanı suan eklıyoruz. Sonuncu eleman

        }

        public int Length
        {
            get { return items.Length; }   //elemansayısını verir
        }
        public T[] Items  // elemanları görmek istersen
        {
            get { return items; }




        }

    }
}

