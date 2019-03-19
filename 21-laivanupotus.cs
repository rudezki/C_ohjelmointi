using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_laivanupotus
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, w, x1, y1, z1 ,w1, number;
            string syote;
            bool result;

            Random zKoordinaatti = new Random();
            z = zKoordinaatti.Next(1, 6);
            w = zKoordinaatti.Next(1, 6);
            Console.WriteLine("Asetetaan laiva 5x5-koordinaatistoon!");


            Koordinaattix:
                Console.WriteLine("Anna koordinaatti X");
                syote = Console.ReadLine();
                result = Int32.TryParse(syote, out number);
                x = number;
            if (x < 1 || x > 5)
                {
                    Console.WriteLine("Virheellinen koordinaatti!");
                    goto Koordinaattix;
                }
                Console.WriteLine("Anna koordinaatti y");
                Koordinaattiy:
                syote = Console.ReadLine();
                result = Int32.TryParse(syote, out number);
                y = number;
            if (x < 1 || x > 5)
                {
                    Console.WriteLine("Virheellinen koordinaatti!");
                    goto Koordinaattiy;
                }
                Console.WriteLine("Sinä aloitat!");
                for (; ; )
                {
                    Ammu:
                    Console.WriteLine("Ammuttava koordinaatti x!");
                    syote = Console.ReadLine();
                    result  = Int32.TryParse(syote, out number);
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
                    } else if (x1 < 1 || y1 < 1 || x1 > 5 || y1 > 5)
                    {
                        Console.WriteLine("Virheellinen koordinaatti");
                      goto Ammu;
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
                    

            }
    }
}
