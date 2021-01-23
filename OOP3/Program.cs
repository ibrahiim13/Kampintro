using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediBaseManager ihtiyacKrediManager = new İhtiyaçKrediManager();
            IKrediBaseManager taşıtKrediManager = new TaşıtKrediManager();
            IKrediBaseManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new fileLoggerService();



            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,fileLoggerService);


            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {ihtiyacKrediManager ,taşıtKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
