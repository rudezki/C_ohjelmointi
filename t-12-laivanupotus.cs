using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_laivanupotus
{

    class Program
    {
        private static int KoneLaiva(Random noppa)
        {
            int arpa = 0;
           
            arpa = noppa.Next(1, 6);
           // wPlane = Koordinaatti.Next(1, 6);
            
            return arpa;
        }
        private static int Suunta(Random noppa)
        {
            int arpa = 0;
            arpa = noppa.Next(1, 4);

            return arpa;
        }

        private static int Read()
        {
            bool result;
            int number;
            string syote;
            syote = Console.ReadLine();
            result = Int32.TryParse(syote, out number);
            return number;
        }

        static void Main(string[] args)
        {
            Random Koordinaatti = new Random();
            Random Suuntima = new Random();
            int x= 0, y= 0, z = 0, w = 0, x1 = 0, y1 = 0, z1 = 0,w1 = 0, shoot1, shoot2, suunta;
            bool alus1 = false, alus2 = false, alus3 = false, alus4 = false, error = false, exit = false;
            z = KoneLaiva(Koordinaatti);
            w = KoneLaiva(Koordinaatti);
            do
            {
                suunta = Suunta(Suuntima);
                if (suunta == 1)
                {
                    w1 = w;
                    z1 = z - 1;
                }
                else if (suunta == 2)
                {
                    w1 = w;
                    z1 = z + 1;
                }
                else if (suunta == 3)
                {
                    z1 = z;
                    w1 = w + 1;
                }
                else if (suunta == 4)
                {
                    z1 = z;
                    w1 = w - 1;
                }
                if (z1 < 1 || z1 > 5 || w1 < 1 || w1 > 5)
                {
                    exit = false;
                }
                else if (z1 > 0 && z1 < 6 && w1 > 0 && w1 < 6)
                {
                    //Console.WriteLine("{0}, {1}", z1, w1);
                    exit = true;
                }
                else
                {
                    //  Console.WriteLine("Virheellinen suunta");
                    exit = false;
                }
            }
            while (exit == false);

                //Console.WriteLine("{0}, {1}", z, w);

            Console.WriteLine("Asetetaan laiva 5x5-koordinaatistoon!");
            do
            {
                Console.WriteLine("Aseta laivan koordinaatti X");
                x = Read();
                Console.WriteLine("Aseta laivan koordinaatti y");
                y = Read();

                if (x < 1 || y < 1 || x > 5 || y > 5)
                {
                    Console.WriteLine("Virheellinen koordinaatti! Yritä uudelleen");
                    exit = false;
                }
                else if (x > 0 && x < 6 && y > 0 && y < 6)
                {
                    exit = true;
                }
                do
                {
                    Console.WriteLine("Mihin suuntaan laivan seuraava piste laitetaan? (y)lös, (a)las, (v)asen, (o)ikea");
                    string syote = Console.ReadLine();
                    if (syote == "v")
                    {
                        y1 = y;
                        x1 = x - 1;
                    }
                    else if (syote == "o")
                    {
                        y1 = y;
                        x1 = x + 1;
                    }
                    else if (syote == "y")
                    {
                        x1 = x;
                        y1 = y + 1;
                    }
                    else if (syote == "a")
                    {
                        x1 = x;
                        y1 = y - 1;
                    }
                    if (y1 < 1 || y1 > 5 || x1 < 1 || x1 > 5)
                    {

                        Console.WriteLine("Laiva menee koordinaatiston ulkopuolelle");
                        exit = false;
                    }
                    else if (x1 > 0 && x1 < 6 && y1 > 0 && y1 < 6)
                    {
                        //Console.WriteLine("{0}, {1}", y1, x1);
                        exit = true;
                    } else
                    {
                        Console.WriteLine("Virheellinen suunta");
                        exit = false;
                    }

                }
                while (exit == false);
            }
            while (exit == false);

            Console.WriteLine("Sinä aloitat!");
            exit = false;
            do
            {
                error = false;
                Console.WriteLine("Ammuttava koordinaatti x!");
                x1 = Read();
                Console.WriteLine("Ammuttava koordinaatti y!");
                y1 = Read();
                if (x1 == z && y1 == w)
                {
                    Console.WriteLine("Sait osuman!");
                    alus1 = true;
                }
                else if (x1 == z1 && y1 == w1)
                {
                    Console.WriteLine("Sait osuman!");
                    alus2 = true;
                }
                
                if (alus1 == true && alus2 == true)
                {
                    Console.WriteLine("Alus upposi! Voitit pelin!");
                    Console.ReadKey();
                    exit = true;
                }
                else if (x1 < 1 || y1 < 1 || x1 > 5 || y1 > 5)
                {
                    Console.WriteLine("Virheellinen koordinaatti");
                    error = true;
                }
                if (exit == false && error == false)
                {
                    shoot1 = KoneLaiva(Koordinaatti);
                    shoot2 = KoneLaiva(Koordinaatti);
                    Console.WriteLine("Tietokone ampui koordinaatteihin {0} ja {1}", shoot1, shoot2);

                    if (shoot1 == x && shoot2 == y)
                    {
                        Console.WriteLine("Tietokone sai osuman!");
                        alus3 = true;
                    } else if (shoot1 == x1 && shoot2 == y1)
                    {
                        Console.WriteLine("Tietokone sai osuman!");
                        alus4 = true;
                    }
                    if (alus3 == true && alus4 == true)
                    {
                        Console.WriteLine("Aluksesi upposi! Hävisit pelin!");
                        exit = true;
                    }

                    else
                    {
                        Console.WriteLine("Kumpikaan ei voittanut! Uusi kierros!");
                    }
                }
            }
            while (exit == false);
        }
    }
}
