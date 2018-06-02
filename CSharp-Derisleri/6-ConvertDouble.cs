using System;
namespace SampleCodes {
    class Program {
        static void Main (string[] args) {
            double boy, kilo, bki;
            Console.Write ("Boyunuzu metre cinsinden giriniz?");
            boy = Convert.ToDouble (Console.Readline ());
            Console.Write ("Kilonuzu kg cinsinden giriniz?");
            kilo = Convert.ToDouble (Console.Readline ());
            bki = kilo / (boy * boy);
            Console.Write ("Beden Kitle Indeksiniz:{0}", bki);
            Console.ReadKey ();
        }
    }
}