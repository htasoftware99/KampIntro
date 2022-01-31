using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.Name = "Hasan";
            customer1.Surname = "Aykaç";
            customer1.CustomerNumber = "123456";
            customer1.TcNo = "11111111111";

            CorporoteCustomer customer2 = new CorporoteCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "101010";
            customer2.CompanyName = "htasoftware";
            customer2.TaxNumber = "987654321";

            Customer customer3 = new CorporoteCustomer();
            Customer customer4 = new IndividualCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
