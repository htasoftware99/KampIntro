﻿string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "java";
string kurs4 = "python";
string kurs5 = "c++";

//array
string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "java", "python", "c++" };

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("for bitti");
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
Console.WriteLine("Sayfa Sonu - Footer");