using System;
namespace Classes {
    public class Person {
        public string Name;
        public void introduce (string to) {
            Console.WriteLine ("Hi {0},I AM {1}", to, Name);
        }
    }

    class Program {
        static void Main (string[] args) {
            var person = new Person ();
            person.Name = "Kara";
            person.introduce = "Ozgur";
            Console.ReadKey ();
        }
    }
}