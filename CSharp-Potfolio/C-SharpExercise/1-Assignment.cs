using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorched_Earth {
    class Program {
        const float G = 9.8F;
        static void Main (string[] args) {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine ("Welcome! We are going to start a calculate the maximun height of the shell and the distance it will travel along the ground-!!!");
            Console.Write ("Angle: ");

            float theta = float.Parse (Console.ReadLine ());
            theta = theta * 0.0174532925F;

            Console.Write ("Initial speed: ");
            float speed = float.Parse (Console.ReadLine ());

            float vox = speed * (float) Math.Cos (theta);
            float voy = speed * (float) Math.Sin (theta);

            float t = voy / G;
            float h = voy * voy / (2 * G);
            float dx = vox * 2 * t;

            Console.WriteLine (string.Format ("Height: {0:f3}", h));
            Console.WriteLine (string.Format ("Distance travalled: {0:f3}", dx));
            Console.Read ();
        }
    }
}   