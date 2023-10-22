using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string user_input;
            int pierwsza, druga;
            Console.WriteLine("Podaj pierwsza liczbe:");
            user_input = Console.ReadLine();
            pierwsza = int.Parse(user_input);
            Console.WriteLine("Podaj druga liczbe:");
            user_input = Console.ReadLine();
            druga = int.Parse(user_input);
            if (pierwsza % druga == 0)
            {
                Console.WriteLine(druga);
                Console.WriteLine("jest dzielnikiem");
                Console.WriteLine(pierwsza);
            }
            else
            {
                Console.WriteLine("nie jest dzielnikiem");
            }
                
            ;
        }
    }
}
