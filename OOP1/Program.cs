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
            product1.UnıtPrice = 500;
            product1.UnıtsInStock = 3;

            // boyle sıralamak yerine asagıdakı gıbı de sıralayabiliriz.

            Product product2 = new Product { Id = 3, CategoryId = 5, ProductName = "Kalem", UnıtPrice = 35, UnıtsInStock = 15 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);




            
           
            










        }
    }
}
