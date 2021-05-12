using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Engin Demiroğ

            Indıvidual ındıvidual1 = new Indıvidual();
            ındıvidual1.Id = 14;
            ındıvidual1.CustomerNumber = "12345";
            ındıvidual1.Name = "Engin";
            ındıvidual1.LastName = "Demiroğ";
            ındıvidual1.TcNumber = "22222222222";

            // Kodlama.io

            Coorporate coorporate1 = new Coorporate();
            coorporate1.Id = 15;
            coorporate1.CustomerNumber = "54321";
            coorporate1.CompanyName = "Kodlama.io";
            coorporate1.TaxNumber = "7865";

            Customer customer3 = new Customer();
            Customer customer4 = new Customer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(ındıvidual1);
            customerManager.Add(coorporate1);



            // Bu bir gerçek müşteri olduğu iin bunda şirket adı olmaz 
            // eğer bu şirket yani tüzel müşteri olsaydı by sefer de tc  numarası vs olmazdı 
            // bu yüzden bu kullanım yanlıştır.
            // SOLID








        }
    }
}
