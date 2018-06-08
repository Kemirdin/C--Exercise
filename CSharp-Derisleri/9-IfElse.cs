using System;
namespace SampleCodes {
    class Program {
        static void Main (string[] args) {
            int sayi, sonuc;
            Console.Write ("Bir sayi giriniz?");
            sayi = Convert.ToOnt32 (Console.ReadLine ());
            sonuc = sayi % 2;
            if (sonuc == 0) {
                Console.Write ("Girilen sayi cifit sayidir.");
            } else {
                Console.Write ("Girilen sayi tek sayidir.");
            }
            Console.ReadKey ();
        }
    }
}