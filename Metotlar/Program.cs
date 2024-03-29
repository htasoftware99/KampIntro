﻿using Metotlar;

Product product1 = new Product();
product1.Adi = "Elma";
product1.Fiyati = 15;
product1.Aciklama = "Amasya Elması";

Product product2 = new Product();
product2.Adi = "Karpuz";
product2.Fiyati = 50;
product2.Aciklama = "Diyarbakır Karpuzu";

Product[] products = new Product[] { product1, product2 };
foreach (Product product in products)
{
    Console.WriteLine(product.Adi);
    Console.WriteLine(product.Fiyati);
    Console.WriteLine(product.Aciklama);
    Console.WriteLine("------------------------");
}

Console.WriteLine("-------------Methods-------------");
//instance
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(product1);
sepetManager.Ekle(product2);

sepetManager.Ekle2("Armut", "Yeşil Armut", 20, 10);
sepetManager.Ekle2("Elma", "Yeşil Elma", 10, 8);
sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuz", 50, 9);
