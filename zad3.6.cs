using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string user_input;
            double waga, wzrost;
            Console.WriteLine("Podaj wage:");
            user_input = Console.ReadLine();
            waga = double.Parse(user_input);
            Console.WriteLine("wzrost w metrach");
            user_input = Console.ReadLine();
            wzrost = double.Parse(user_input);
            Console.WriteLine("twoje bmi to: " + waga/(wzrost*wzrost));
        }
    }
}
