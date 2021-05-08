using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.EgitmenAdi = "ENGİN DEMİROĞ";
            kurs1.KursAdi = "C#";
            kurs1.İzlenmeOrani = 85;

            Kurs kurs2 = new Kurs();
            kurs2.EgitmenAdi = "TUĞBA GÜNDOĞDU";
            kurs2.KursAdi = "JAVA";
            kurs2.İzlenmeOrani = 65;

            Kurs kurs3 = new Kurs();
            kurs3.EgitmenAdi = "MURAT YÜCEDAĞ";
            kurs3.KursAdi = "C++";
            kurs3.İzlenmeOrani = 70;

           

            class Kurs
        {
            public string KursAdi { get; set; }
            public string EgitmenAdi { get; set; }
            public int İzlenmeOrani { get; set; }

        }

      

           
        }
    }

