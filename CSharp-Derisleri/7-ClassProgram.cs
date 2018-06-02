using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasneKolanami {
    class MainClass {
        CModel cm1 = new CModel ();
        Console.Write ("bir seyler giriniz");
        cm1.Name = Console.ReadLine ();
        Console.WriteLine (cm1.Name);
    }
}
}