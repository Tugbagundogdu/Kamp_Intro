using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 60;
            // ise sayi1 kaçtır??
            // bunlar değer tip olduğundan sayi1 20 dir.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] elemanı kaçtırr??
            // bunlar referans tip olduğundan 999 dur.

;


        }
    }
}
