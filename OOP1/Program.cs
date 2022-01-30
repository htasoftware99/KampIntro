using System;

namespace OOP1 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2; //Mobilya
            product.ProductName = "Masa";
            product.UnitPrice = 1000;
            product.UnitsInStock = 50;

            Product product2 = new Product() { Id = 2, CategoryId = 3,
                ProductName = "Süt", UnitPrice = 15, UnitsInStock = 25 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product);
            
        }
    }
}