using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string user_input;
            double srednia;
            Console.WriteLine("podaj srednia");
            user_input = Console.ReadLine();
            srednia = double.Parse(user_input);
            if (srednia < 3.99)
            {
                Console.WriteLine("stypendium nie przysluguje");
            }
            else if (srednia > 4 && srednia < 4.79)
            {
                Console.WriteLine("przysluguje 350zl stypendium");
            }
            else 
            {
                Console.WriteLine("przysluguje 550zl stypendium");
            }
            ;
        }
    }
}
