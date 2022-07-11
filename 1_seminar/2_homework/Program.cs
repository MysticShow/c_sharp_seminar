// using System;

namespace homework2 {

    class Program {

        static void Main() {
            Console.Write("Please enter number one: ");
            byte a = byte.Parse(Console.ReadLine());

            Console.Write("Please enter number two: ");
            byte b = byte.Parse(Console.ReadLine());

            Console.Write("Please enter number three: ");
            byte c = byte.Parse(Console.ReadLine());

            int max = a;

            if (b > a) { max = b; }

            if (c > max) { max = c; }

            Console.WriteLine(max);
        }

    }
}