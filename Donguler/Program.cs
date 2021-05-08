using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            // array yani diziler 

            string[] kurslar = new string[] { "Temel kurs", "python kursu", "c# kursu", "java kursu", "c++ kursu" };


            for (int i = 0; i< kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            // foreach da aynı işlevi görür yukarda yazdığım arrayse bir takma isim, aliaz yani değişken atadığımı farzet 
            // aşağıda kurs dedim foreach tab tab yaptıktn sonra yazıyon aşagıdakileri cw sonra aliazını yazıyon işlem tamam
            // dizileri dönmeni sağlar.daha kolay bunu kullan tugba.

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }



        }   




    }
}
