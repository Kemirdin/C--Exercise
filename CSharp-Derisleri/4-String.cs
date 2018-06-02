using System;
namespace SampleCodes {
    class Program {
        static void Main (string[] args) {
            string tcno = "123456789";
            string adsoyad = "Kemirdin Kaynam";
            string gorevi = "yazilimci";
            string maas = 9494;
            console.Write ("TC KIMLIK NO:" + tcno + "" + "ADI SOYAD:" + adsoyad);
            console.Write ("GOREVI:{0} MAASI:{1}", gorevi, maas);
            console.Readkey ();
        }
    }
}