namespace homework6 {

    class Program {

        static void Main() {
            
            int num = int.Parse(Console.ReadLine());

             Console.WriteLine(num > 99 ? num.ToString()[2] : '-');
             Console.ReadKey(true);

        }
     }
}