﻿Customer customer1 = new Customer { Id = 1, FirstName = "Hasan", LastName = "Aykac", City = "Ankara" };
Customer customer2 = new Customer(2, "Mehmed", "Bugra", "İstanbul");
Console.WriteLine(customer2.FirstName);
class Customer
{
    //Default Constructor
    public Customer()
    {
        
    }
    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}