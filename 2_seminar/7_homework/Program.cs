namespace homework7 {

    class Program {

        static void Main() {
            
            Console.Write("Please enter the day of the week: ");
            byte n = byte.Parse(Console.ReadLine());

            if(n <= 5) {

                Console.Write("No. Today is not a day off =(");

            } else if (n <= 7) {

                Console.Write("Yes! Today is a day off!");

            } else {
                Console.Write("Enter a day from 1 to 7, please =)");
            }
            
        }
    }
}