using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasneKolanami {
    class MainClass {
        String name;
        public String Name {
            get { return name; }
            set {
                if (value.length < 5) {
                    name = "Hatali sifreli girdeniz";
                } else {
                    name = value;
                }
            }
        }
    }
}
}