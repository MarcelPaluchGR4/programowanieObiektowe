using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string user_input;
            double pierwsza, druga;
            string znak;
            Console.WriteLine("Podaj pierwsza liczbe:");
            user_input = Console.ReadLine();
            pierwsza = double.Parse(user_input);
            Console.WriteLine("Podaj druga liczbe:");
            user_input = Console.ReadLine();
            druga = double.Parse(user_input);
            Console.WriteLine("Podaj znak:");
            znak = Console.ReadLine();
            if (znak == "+")
            {
                Console.WriteLine("Wynik to:");
                Console.WriteLine(pierwsza+druga);
            }
            else if (znak == "-")
            {
                Console.WriteLine("Wynik to:");
                Console.WriteLine(pierwsza-druga);
            }
            else if (znak == "/")
            {
                Console.WriteLine("Wynik to:");
                Console.WriteLine(pierwsza/druga);
            }
            else
            {
                Console.WriteLine("Wynik to:");
                Console.WriteLine(pierwsza*druga);
            }
        }
    }
}
