using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string user_input;
            double converted;
            Console.WriteLine("Podaj rok:");
            user_input = Console.ReadLine();
            converted = int.Parse(user_input);
            if (((converted % 4 == 0) && (converted % 100 != 0)) || (converted % 400 == 0))
            {
                Console.WriteLine("Rok przestepny");
            }
            else
            {
                Console.WriteLine("Rok nieprzestepny");
            }
                
            ;
        }
    }
}
