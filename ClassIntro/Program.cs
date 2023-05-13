Kurs kurs1 = new Kurs();
kurs1.KursAdi = "c#";
kurs1.Egitmen = "Hasan";
kurs1.IzlenmeOrani = 50;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "c++";
kurs2.Egitmen = "Tuğra";
kurs2.IzlenmeOrani = 55;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "python";
kurs3.Egitmen = "Ali";
kurs3.IzlenmeOrani = 60;

//Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};
foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}