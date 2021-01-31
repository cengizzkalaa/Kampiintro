using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //classın içine bu şekilde yazabiliriz yukarıdaki yerine 2. seçenek

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //case sensitive
            //PascalCase   //camelCase 
            ProductManager productManager = new ProductManager(); //Productmanager türünde productmanager oluşturduk. ProductManager(class)
                                                                  //stack kısmı                 =  heap kısmı

            productManager.Add(product1); //product1 i ProductManager class ına gönderir.
            //diziler, classü abstract class, interface ... referans tip
            //ref out



        }
    }
}
