List<Category> categories = new List<Category>
{
    new Category { CategoryId = 1, CategoryName = "Bilgisayar"},
    new Category { CategoryId = 2, CategoryName = "Telefon"},
};

List<Product> products = new List<Product>
{
    new Product { ProductId = 1, CategoryId=1, ProductName="Asus Laptop", Description="32gb ram", UnitPrice=10000, UnitsInStock=5},
    new Product { ProductId = 1, CategoryId=1, ProductName="Acer Laptop", Description="12gb ram", UnitPrice=5000, UnitsInStock=15},
    new Product { ProductId = 1, CategoryId=1, ProductName="HP Laptop", Description="16gb ram", UnitPrice=10600, UnitsInStock=2},
    new Product { ProductId = 1, CategoryId=2, ProductName="Samsung Telefon", Description="8gb ram", UnitPrice=11000, UnitsInStock=25},
    new Product { ProductId = 1, CategoryId=2, ProductName="Apple Telefon", Description="4gb ram", UnitPrice=12000, UnitsInStock=35}
};

Console.WriteLine("----------Algoritmik----------");

foreach (var product in products)
{
    if (product.UnitPrice > 5000 && product.UnitsInStock > 10)
    {
        Console.WriteLine(product.ProductName);
    }

}

Console.WriteLine("-------------Linq-----------------");
var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 10);
foreach (var product in result)
{
    Console.WriteLine(product.ProductName);
}

GetProducts(products);

static List<Product> GetProducts(List<Product> products)
{
    List<Product> filteredProducts = new List<Product>();
    foreach (var product in products)
    {
        if (product.UnitPrice > 5000 && product.UnitsInStock > 10)
        {
            filteredProducts.Add(product);
        }

    }
    return filteredProducts;
}

static List<Product> GetProductsLinq(List<Product> products)
{
    //return (List<Product>)products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 10);
    return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 10).ToList();
}
class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string Description { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}

