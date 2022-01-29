using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Mobile Phone";
            product1.Price = 5000;
            product1.description = "Asus Zenfone 2";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Laptop";
            product2.Price = 15000;
            product2.description = "i5 16GB ram";

            Product[] products = new Product[] { product1, product2 };
            
            foreach (Product product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.description);
                Console.WriteLine(product.stock);
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("--------Methods-------");

            //instance
            //encapsulation
            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);

            cartManager.Add2("Armut", "Sarı Armut", 5, 10);
            cartManager.Add2("kiraz", "kırmızı", 7, 7);
            cartManager.Add2("Elma", "Yeşil Elma", 3, 13);

        }
    }
}

