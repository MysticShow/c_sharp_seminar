// using System;

namespace homework3 {

    class Program {

        static void Main() {
            Console.Write("Please enter a number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(a % 2 == 0 ? "Yes, even number!" : "No, not an even number");

        }

    }
}