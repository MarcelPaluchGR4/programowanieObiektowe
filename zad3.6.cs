using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string user_input;
            double waga, wzrost, BMI;
            Console.WriteLine("Podaj wage:");
            user_input = Console.ReadLine();
            waga = double.Parse(user_input);
            Console.WriteLine("wzrost w metrach");
            user_input = Console.ReadLine();
            wzrost = double.Parse(user_input);
            BMI = waga/(wzrost*wzrost);
            Console.WriteLine("Twoje BMI to: " + BMI);
            if (BMI < 16)
            {
                Console.WriteLine("wygłodzenie");
            }
            else if (BMI > 16 && BMI < 16.99)
            {
                Console.WriteLine("wychudzenie");
            }
            else if (BMI > 17 && BMI < 18.49)
            {
                Console.WriteLine("niedowaga");
            }
            else if (BMI > 18.5 && BMI < 24.99)
            {
                Console.WriteLine("pożądana masa ciała");
            }
            else if (BMI > 25 && BMI < 29.99)
            {
                Console.WriteLine("nadwaga");
            }
            else if (BMI > 30 && BMI < 34.99)
            {
                Console.WriteLine(" otyłość I stopnia ");
            }
            else if (BMI > 35 && BMI < 39.99)
            {
                Console.WriteLine("otyłość II stopnia ");
            }
            else
            {
                Console.WriteLine("otyłość III stopnia ");
            }
        }
    }
}
