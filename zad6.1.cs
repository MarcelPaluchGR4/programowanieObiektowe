using System;

namespace ConsoleApplication1
{
    class Prostokat
    {
        private double _dlugosc, _szerokosc;

        public Prostokat(double dlugosc, double szerokosc)
        {
            _dlugosc = dlugosc;
            _szerokosc = szerokosc;
        }
        
        private static double Powierzchnia(Prostokat prostokat)
        {
            return prostokat._dlugosc * prostokat._szerokosc;
        }

        private static double Obwod(Prostokat prostokat)
        {
            return 2 * prostokat._dlugosc + 2 * prostokat._szerokosc;
        }

        public static void Prezentuj(Prostokat prostokat)
        {
            Console.WriteLine(Powierzchnia(prostokat));
            Console.WriteLine(Obwod(prostokat));
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Prostokat prostokat;
            prostokat = new Prostokat(2.3, 5.8);
            Prostokat.Prezentuj(prostokat);
        }
    }
}
