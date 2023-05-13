using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.ProductName = "Masa";
product1.CategoryId = 2;
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock=5, ProductName="Kalem", UnitPrice = 20};

//PascaLCase    //camelCase
ProductManager productManager = new ProductManager();
productManager.Add(product1);
//productManager.Topla2(10, 15);
//int toplamaSonucu = productManager.Topla(3, 6);
//Console.WriteLine(toplamaSonucu * 2);