using OOP3;
using System.Collections.Generic;

//IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
//ihtiyacKrediManager.Calculate();

//TasitKrediManager tasitKrediManager = new TasitKrediManager();
//tasitKrediManager.Calculate();

//KonutKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Calculate();

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
//basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService()});


List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

