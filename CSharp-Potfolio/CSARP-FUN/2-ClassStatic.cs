using System;
namespace Classes {
    public class Person {
        public string Name;
        public void introduce (string to) {
            Console.WriteLine ("Hi {0},I AM {1}", to, Name);
        }
        public static Person parse (string str) {
            var person = new Person ();
            person.Name = str;
            return person;
        }
    }

    class Program {
        static void Main (string[] args) {

            var person = Person.parse ("Kara");
            person.introduce = "Ozgur";
            Console.ReadKey ();
        }
    }
}