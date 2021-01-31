using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();


            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();


            // KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            // Aşağıdakiyle de aynı sonucu alırız. Çünkü İnterfacelerde o interface i implement e eden classın referasn numarasını tutabilir.
            //IKrediManager iihtiyacKrediManager = new IhtiyacKrediManager();
            //iihtiyacKrediManager.Hesapla();


            //IKrediManager ttasitKrediManager = new TasitKrediManager();
            //ttasitKrediManager.Hesapla();


            //IKrediManager kkonutKrediManager = new KonutKrediManager();
            //kkonutKrediManager.Hesapla();


            // Burada şimdi müşterinin kredi başvurusunda bulundugunu varsıyoyuruz ve aşağıdaki panel çalışanın ekranında açı

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService);  // ekrandan ihtiyac ı seçtiğinizde onu hesapladık.


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
