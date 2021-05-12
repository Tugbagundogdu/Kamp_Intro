using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAYSLERDE EKLEME YAPAMAZSIN BU YÜZDEN COLLECTİONSLARI KULLANIRIZ.

            // string[] isimler = new string[] { "Engin" , "Kerem" , "Murat" , "Halil"  };
            // Console.WriteLine(isimler[0]);
            // Console.WriteLine(isimler[1]);
            // Console.WriteLine(isimler[2]);
            // Console.WriteLine(isimler[3]);

            // isimler = new string[5];
            // isimler[4] = "Tuğba";
            // Console.WriteLine(isimler[4]);
            // çalışır ancaaaak sadece son eklediğini çalıştırır.bi öncekileri görmek bak kanıtı aşağıda

            // Console.WriteLine(isimler[3]);
            // 3.elemanı yani halili yazdırmaya çalıştığımda çalışmayacaktır.Çünkü stock ve heep olayından ötürü
            // birbirine atanıyo falan öyle bişi boşver olmadığını bil yeter.
            // ctrl k ctrl L hepsini // yapar.



            List<string> isimler2 = new List<string> {"Engin","Kerem","Murat","Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            // şimdi ilkeri eklenek için add demem gerekiyor.

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[3]);

            // şimdi ise gördüğün gibi hem eklediğimi hemde öncekilerini yazdırır.


            






        }
    }
}
