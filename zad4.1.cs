using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int rozmiar;
            int i = 0;
            Console.WriteLine("podaj rozmaiar tablicy");
            rozmiar = int.Parse(Console.ReadLine());
            int[] tablica = new int[rozmiar];
            while (i < rozmiar)
            {
                Console.WriteLine("podaj " + i + " element tablicy");
                tablica[i] = int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("oto poszczegolne elementy tablicy");
            i = 0;
            while (i < rozmiar)
            {
                Console.WriteLine(i + " element tablicy to: " + tablica[i]);
                i++;
            }
        }
    }
}
