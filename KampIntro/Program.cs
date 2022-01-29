string Kurs1 = "C#";
string Kurs2 = "JAVA";
string Kurs3 = "Python";

string[] kurslar = new string[]
{
    "C#","JAVA","Python","c","c++"
};

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("footer");