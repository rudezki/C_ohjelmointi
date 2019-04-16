using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_16_Aritmetiikka
{
    class Program
    {
        //Satunnaisgeneraattori desimaaliluvuille
        private static double Rnd2(Random noppa)
        {
            double luku1 = noppa.Next(1,101);
            return luku1;
        }
        //Aliohjelma numeroiden lukemiselle
        private static double Syote()
        {
            bool result;
            double number;
            string syote;
            syote = Console.ReadLine();
            result = Double.TryParse(syote, out number);
            return number;
        }
        //Tiedon syöttöä varten oma aliohjelma
        private static string Read()
        {
            string syote;
            syote = Console.ReadLine();
            return syote;
        }
        //numeron randomisaatiogeneraattoriin on sisällytetty tarkistus kokonaislukuja ja negatiivisia lukuja varten.
        private static Double Randomizer(bool kokonais, bool minus, Random Rnd)
        {
            double luku = 0;
            if (kokonais == false && minus == false)
            {
                luku = Rnd.NextDouble() * (100 - 0) + 0;
                luku = Math.Round(luku, 2, MidpointRounding.AwayFromZero);
            }
            else if (kokonais == false && minus == true)
            {
                luku = Rnd.NextDouble() * (100 - (-100)) + (-100);
                luku = Math.Round(luku, 2, MidpointRounding.AwayFromZero);
            }
            else if (kokonais == true && minus == true)
            {
                luku = Rnd.Next(-100, 101);
            }
            else
            {
                luku = Rnd.Next(1, 101);
            }
            return luku;
        }
        //Aliohjelma vastausten vertailulle
        private static bool Arvaus(double kysymys, double vastaus)
        {

            if (kysymys == vastaus)
            {
                Console.WriteLine("Oikein!");
                return true;
            } else 
            {
                Console.WriteLine("Väärin! :(");
                return false;
            }
        }

        static void Main(string[] args)
        {
            bool exit = false, kokonais, minus;
            double answer = 0, answer1, luku1 = 0, luku2 = 0;
            Random satunnainen = new Random();
            int palkinto = 0;
            //ohjelma pyörii kunnes valitaan "exit"
            do
            {
                Console.WriteLine("Haluatko kutsua vain kokonaislukuja? Jos et niin kirjoita 'e'");
                if (Console.ReadLine() == "e")
                {
                    kokonais = false;
                } else
                {
                    kokonais = true;
                }
                Console.WriteLine("Haluatko kutsua pelkkiä positiivisia lukuja? Jos et niin kirjoita 'e'");
                if (Console.ReadLine() == "e")
                {
                    minus = true;
                } else
                {
                    minus = false;
                }
                Console.WriteLine("Haluatko laskea \n1.Yhteenlaskun \n2.Jakolaskun \n3.Erotuslaskun vai \n4.Kertolaskun \n5.Quit \nOlet voittanut {0} palkintoa tähän asti.\nKaikki luvut pyöristetään kahdenteen desimaaliin.", palkinto);
                    switch (Syote())
                    {
                    //switch case skenaario laskuja varten
                        case 1:
                        //Aliohjelmasta otetaan luvut
                        luku1 = Randomizer(kokonais, minus, satunnainen);
                        luku2 = Randomizer(kokonais, minus, satunnainen);
                        Console.WriteLine("{0} + {1} = ?", luku1, luku2);
                        answer = luku1 + luku2;
                        answer = Math.Round(answer, 2, MidpointRounding.AwayFromZero);
                        //Käytetään syötettä 

                        Console.WriteLine("{0}", answer);
                        answer1 = Syote();
                            //Aliohjelmaa käytetään arvauksen osoittamiseksi oikeaksi, palkinto lisätään, jos vastaus on oikein
                            if (Arvaus(answer, answer1) == true)
                            {
                                palkinto++;
                            }
                            break;
                        case 2:
                        //kutsutaan luvut aliohjelmasta
                        luku1 = Randomizer(kokonais, minus, satunnainen);
                        luku2 = Randomizer(kokonais, minus, satunnainen);
                        // Jakolasku jaetaan kahden satunnaisluvun kertomalla, jotta jakolaskusta tulisi aina jokin kokonaisluku.
                        double ans1 = luku1 * luku2;
                        ans1 = Math.Round(ans1, 2, MidpointRounding.AwayFromZero);
                        answer = ans1 / luku1;
                        answer = Math.Round(answer, 2, MidpointRounding.AwayFromZero);
                        Console.WriteLine("{0} / {1} = ?", ans1, luku1);
                        Console.WriteLine("{0}", answer);
                        answer1 = Syote();
                        //Tarkistetaan vastaus, lisätään palkinto jos vastaus on oikea
                        if (Arvaus(answer, answer1) == true)
                            {
                                palkinto++;
                            }
                            break;
                        case 3:
                        luku1 = Randomizer(kokonais, minus, satunnainen);
                        luku2 = Randomizer(kokonais, minus, satunnainen);
                        answer = luku1 - luku2;
                        Console.WriteLine("{0} - {1} = ?", luku1, luku2);
                        Console.WriteLine("{0}", answer);
                        answer1 = Syote();
                        if (Arvaus(answer, answer1) == true)
                        {
                            palkinto++;
                        }
                            break;
                        case 4:
                        luku1 = Randomizer(kokonais, minus, satunnainen);
                        luku2 = Randomizer(kokonais, minus, satunnainen);
                        answer = luku1 * luku2;
                        Console.WriteLine("{0} * {1} = ?", luku1, luku2);
                        Console.WriteLine("{0}", answer);
                        answer1 = Syote();
                        if (Arvaus(answer, answer1) == true)
                        {
                            palkinto++;
                        }
                        break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            break;

                    }

                
            }
            while (exit == false);
            
        }
    }
}
