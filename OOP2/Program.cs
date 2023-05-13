using OOP2;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNo = "12345";
customer1.Name = "Hasan";
customer1.Surname = "Aykaç";
customer1.TcNo = "1234567890";

CorporateCustomer customer2 = new CorporateCustomer();
customer2.Id = 2;
customer2.CustomerNo = "54321";
customer2.CompanyName = "htasoftware";
customer2.TaxNo = "1234567890";

Customer customer3 = new IndividualCustomer();
Customer customer4 = new CorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);