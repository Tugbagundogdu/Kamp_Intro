using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager needCreditManager = new NeedCreditManager();
            ICrediManager vehicleCreditManager = new VehicleCreditManager();
            ICrediManager housingCrediManager = new HousingCrediManager();

            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();


            RecourseManager recourseManager = new RecourseManager();
            recourseManager.BasvuruYap(needCreditManager , databaseLoggerService);


            List<ICrediManager> krediler = new List<ICrediManager>() {needCreditManager , vehicleCreditManager};
            //recourseManager.KrediOnBilgilendirmesiYap(krediler);




            

        }
    }
}
