using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string user_input;
            int pierwsza, druga, trzecia;
            Console.WriteLine("Podaj pierwsza liczbe:");
            user_input = Console.ReadLine();
            pierwsza = int.Parse(user_input);
            Console.WriteLine("Podaj druga liczbe:");
            user_input = Console.ReadLine();
            druga = int.Parse(user_input);
            Console.WriteLine("Podaj trzecia liczbe:");
            user_input = Console.ReadLine();
            trzecia = int.Parse(user_input);
            if (pierwsza > druga && pierwsza > trzecia)
            {
                Console.WriteLine(pierwsza + " jest najwieksza liczba");
            }
            else if (druga > pierwsza && druga > trzecia)
            {
                Console.WriteLine(druga + " jest najwieksza liczba");
            }
            else
            {
                Console.WriteLine(trzecia + " jest najwieksza liczba");
            }    
            ;
        }
    }
}
