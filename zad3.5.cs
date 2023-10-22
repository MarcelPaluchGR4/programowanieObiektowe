using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string user_input;
            double pierwszy, drugi, trzeci, delta;
            string znak;
            Console.WriteLine("Podaj wspolczynnik a x^2:");
            user_input = Console.ReadLine();
            pierwszy = double.Parse(user_input);
            Console.WriteLine("Podaj wspolczynnik b x:");
            user_input = Console.ReadLine();
            drugi = double.Parse(user_input);
            Console.WriteLine("Podaj stala c:");
            user_input = Console.ReadLine();
            trzeci = double.Parse(user_input);
            delta = drugi * drugi - (4 * pierwszy * trzeci);
            if (delta > 0)
            {
                Console.WriteLine("rownanie ma 2 rozwiazania");
            }
            else if (delta == 0)
            {
                Console.WriteLine("rownanie ma jeden pierwiastek podwojny");
            }
            else
            {
                Console.WriteLine("rownanie nie ma rzeczywistych rozwiazan");
            }
        }
    }
}
