// using System;

namespace homework3 {

    class Program {

        static void Main() {
            Console.Write("Please enter a number N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("All even number: \n");
            for(int i = 0; i < N; i++) {
                if(i % 2 == 0) {
                    Console.WriteLine("{0}", i);

                }
            }

        }

    }
}