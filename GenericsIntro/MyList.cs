using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>  //T type dan geliyor.
    {

        T[] items;    // class ın butun operasyonlarının yani metodlarının erişebilecegi bi dizi tanımlıyoruz burada. T tipinde items tanımladık çünkü string de olabilir intte olabilir.
        //contsructor denir alttaki bloğa
        public MyList()  // burası bir metottur operasyon ctor yaz tab tab
        {

            items = new T[0];

        }
        public void Add(T item) //ben sana t olarak ne verirsem o an  ne istersem int string farketmez o olur aynı zamanda burası bir operasyon yani metotdur
        {
            T[] tempArray = items;  //Gecici dizinin referansı itemsın referansı demek. Elemanlar kaybolmucak sabitlenicek. Çünkü newledigimizde yeni ref no alıyor diger elemanlar kayboluyor. Bu yüzden bu işlemi yapıyoruz.
            items = new T[items.Length + 1];  //dizinin elaman sayısını 1 arttır
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // temparray e verdigimiz gecici elemanları sırasıyla kendi üzerimize geri alıyoruz ve items bütün elemanlarına tekrar kavuşur.

            }

            items[items.Length - 1] = item;

        }

        public int Length
        {
            get { return items.Length; }   //elemansayısını verir
        }
        public T[] Items
        {
            get { return items; }




        }

    }
}

