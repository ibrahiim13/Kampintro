using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "İbrahim";
            int yas = 20;
            


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "İbrahim";
            kurs1.IzlenmeOranı = 68;

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);


            

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen  { get; set; }

        public string IzlenmeOranı { get; set; }
    }
}
