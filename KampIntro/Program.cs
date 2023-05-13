string kategoriEtiketi = "kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 7.35;
double dolarBugun = 7.35;

if (dolarDun > dolarBugun)
{
    Console.WriteLine("Azalış butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış butonu");
}
else
{
    Console.WriteLine("Değişmedi butonu");
}

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı Ayarlar Butonu");
}
else
{
    Console.WriteLine("Giriş Yapma Butonu");
}

Console.WriteLine(kategoriEtiketi);