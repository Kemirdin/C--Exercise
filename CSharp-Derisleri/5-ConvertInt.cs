using System;
namespace SampleCodes {
    class Program {
        static void Main (string[] args) {
            int sayi1, sayi2, toplam;
            Console.Write ("1.Sayiyi Giriniz");
            sayi1 = Convert.ToInt16 (Console.Readline ());
            Console.Write ("2.Sayiyi Giriniz");
            sayi2 = Convert.ToInt16 (Console.Readline ());
            toplam = sayi1 + sayi2;
            Console.Write ("SAYILARIN TOPLAMI:{0}", toplam);
            Console.ReadKey ();
        }
    }
}