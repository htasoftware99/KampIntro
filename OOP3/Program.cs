using System;
using System.Collections.Generic;

namespace OOP3 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacKrediManager = new IhtiyacKrediManager();
            

            ICreditManager tasitKrediManager = new TasitKrediManager();
            

            ICreditManager konutKrediManager = new KonutKrediManager();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService(), new FileLoggerService());

            List<ICreditManager> krediler = new List<ICreditManager>() { ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmeYap(krediler);

        }
    }
}