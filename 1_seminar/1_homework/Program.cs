// using System;

namespace homework1{

    class Program{

        static void Main(){
            Console.Write("Please enter number one: ");
            byte a = byte.Parse(Console.ReadLine());

            Console.Write("Please enter number two: ");
            byte b = byte.Parse(Console.ReadLine());

            if (a>b) {
                Console.WriteLine(a + " > " + b);

            } else {
                 Console.WriteLine(a + " < " + b);

            }
        }

    }
}