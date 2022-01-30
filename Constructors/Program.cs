using System;

namespace Constructors 
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id= 1, Name= "Hasan", Surname="Aykaç", City = "Ankara"};
            Customer customer2 = new Customer(2,"Bial", "Bilgili", "Çorum");
            
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        //Default Constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            Name = firstName;
            Surname = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}
