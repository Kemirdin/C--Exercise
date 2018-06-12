using System;
namespace SampleCodes {
    class Program {
        static void Main (string[] args) {
            int viza1, viza2, final;
            Console.Write ("1. Visa numurunuzi giriniz?");
            visa1 = Convert.ToOnt32 (Console.ReadLine ());
            Console.Write ("2. Visa numurunuzi giriniz?");
            visa2 = Convert.ToOnt32 (Console.ReadLine ());
            Console.Write ("final numurunuzi giriniz?");
            final = Convert.ToOnt32 (Console.ReadLine ());

            if (visa1>=50 && visa2>=50 && final>=50) {
                Console.Write ("Dersi basari ile tamamladiniz.");
            } else {
                Console.Write ("Yaz okuluna kaldiniz.");
            }
            Console.ReadKey ();
        }
    }
}