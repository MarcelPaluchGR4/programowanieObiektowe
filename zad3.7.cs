using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string user_input;
            int dzien;
            Console.WriteLine("podaj numer dnia tygodnia");
            user_input = Console.ReadLine();
            dzien = int.Parse(user_input);
            switch (dzien)
            {
                case 1:
                    Console.WriteLine("poniedzialek");
                    break;
                case 2:
                    Console.WriteLine("wtorek");
                    break;
                case 3:
                    Console.WriteLine("sroda");
                    break;
                case 4:
                    Console.WriteLine("czwartek");
                    break;
                case 5:
                    Console.WriteLine("piatek");
                    break;
                case 6:
                    Console.WriteLine("sobota");
                    break;
                case 7:
                    Console.WriteLine("niedziela");
                    break;
            }
        }
    }
}
