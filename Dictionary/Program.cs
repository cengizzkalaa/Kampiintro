using Dictionary;
using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Customer Information");


            MyDictionary<string, int> customerInformation = new MyDictionary<string, int>();

            customerInformation.Add("Cengiz Kala", 27 );
            customerInformation.Add("Sevim Kasacı", 26 );
            customerInformation.Add("Anıl Güzel", 27);
            customerInformation.Add("Anıl Kaya", 25);
            customerInformation.Add("Fırat Akyol", 18);



        }


    }


}

