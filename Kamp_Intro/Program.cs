using System;

namespace Kamp_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 3200;
            double faizOrani = 3.42;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 3.45;
            double dolarBugun = 3.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kulanıcı Ayarları Butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yapınız Butonu");
            }
           
            
            
        
          

        }
    }
}
