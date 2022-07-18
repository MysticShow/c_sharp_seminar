namespace homework5 {

    class Program {

        static void Main() {

            while(true) {

                string num = Console.ReadLine();

                if(!num.Equals("exit")) {

                    Console.WriteLine("{0}->{1}", num, num[1]);

                } else {

                    break;

                }
            }
        }
    }
}