using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_laivanupotus
{
    class Program
    {
        //private static int laivaKoordinaatit(int koordinaattiX, int koordinaattiY)
        //{

        //}
        static void Main(string[] args)
        {
            int x= 0, y= 0, z, w, x1, y1, z1 ,w1, number;
            string syote;
            bool result;
            bool exit = false;

            Random zKoordinaatti = new Random();
            z = zKoordinaatti.Next(1, 6);
            w = zKoordinaatti.Next(1, 6);
            Console.WriteLine("Asetetaan laiva 5x5-koordinaatistoon!");
            do
            {
                Console.WriteLine("Aseta laivan koordinaatti X");
                syote = Console.ReadLine();
                result = Int32.TryParse(syote, out number);
                x = number;
                Console.WriteLine("Aseta laivan koordinaatti y");
                syote = Console.ReadLine();
                result = Int32.TryParse(syote, out number);
                y = number;
                if (x < 1 || y < 1 || x > 5 || y > 5)
                {
                    Console.WriteLine("Virheellinen koordinaatti! Yritä uudelleen");
                    exit = false;
                }
                else if (x > 0 && x < 6 && y > 0 && y < 6)
                {
                    exit = true;
                }
            }
            while (exit == false);

            Console.WriteLine("Sinä aloitat!");
            do
            {
                Console.WriteLine("Ammuttava koordinaatti x!");
                syote = Console.ReadLine();
                result = Int32.TryParse(syote, out number);
                x1 = number;
                Console.WriteLine("Ammuttava koordinaatti y!");
                syote = Console.ReadLine();
                result = Int32.TryParse(syote, out number);
                y1 = number;
                if (x1 == z && y1 == w)
                {
                    Console.WriteLine("Osui ja upposi! Voitit pelin!");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }
                else if (x1 < 1 || y1 < 1 || x1 > 5 || y1 > 5)
                {
                    Console.WriteLine("Virheellinen koordinaatti");
                } else
                {
                    exit = false;
                }

                Random zAmmus = new Random();
                z1 = zAmmus.Next(1, 6);
                w1 = zAmmus.Next(1, 6);
                Console.WriteLine("Tietokone ampui koordinaatteihin {0} ja {1}", z1, w1);

                if (z1 == x && w1 == y)
                {
                    Console.WriteLine("Aluksesi upposi! Hävisit pelin! :(");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }
                Console.WriteLine("Kumpikaan ei voittanut! Uusi kierros!");
            }
            while (exit == false);
        }
    }
}
