using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager // Ürünle ilgi operasyonlar var burada ürün servisi ( ekleme güncelleme silme listeleme gibi )

    {   //void
        //encapsulation
        public void Add(Product product)  //string adı gibi yani Product türünde product veriyosun.
        {
            Console.WriteLine(product.ProductName + "  eklendi.");


        }

        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }




    }
}
