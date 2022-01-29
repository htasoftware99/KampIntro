using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi: " + product.Name);
        }
        public void Add2(string ProductName, string description, int price, int stock)
        {
            Console.WriteLine("Sepete Eklendi!!!: " + ProductName);
        }
        
    }
}
