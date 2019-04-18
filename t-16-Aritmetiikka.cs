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
        private static Double Randomizer(bool kokonais, Random Rnd)
        {
            double luku = 0;
            if (kokonais == false)
            {
                luku = Rnd.NextDouble() * (100 - 0) + 0;
                luku = Math.Round(luku, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                luku = Rnd.Next(1, 101);
            }
            return luku;
        }
        private static string Kokonaisluvut(bool kokonais)
        {
            if (kokonais==false)
            {
                return "Kokonaisluvut ovat pois päältä";
            }
            else
            {
                return "Kokonaisluvut ovat päällä";
            }
        }
        private static string JakolaskunOsamäärä(bool jakolasku)
        {
            if (jakolasku==false)
            {
                return "Jakolaskun osamäärä voi olla desimaaliluku";
            }
            else
            {
                return "Jakolaskun osamäärät ovat vain kokonaislukuja";
            }
        }
        private static string Miinus(bool minus)
        {
            if (minus==false)
            {
                return "Vastaus ei voi olla negatiivinen";

            }
            else
            {
                return "Vastaus voi olla negatiivinen";
            }
        }
        private static bool Kok()
        {
            
            Console.WriteLine("Haluatko kutsua vain kokonaislukuja? Jos et niin kirjoita 'e'");
            
            if (Read() == "e")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool Neg()
        {
            Console.WriteLine("Voiko vastaus olla negatiivinen? Jos ei niin kirjoita 'e'");
            
            if (Read() == "e")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool Div()
        {
            Console.WriteLine("Onko jakolaskun osamäärän pakko olla kokonaisluku? Jos ei niin kirjoita 'e'");
            
            if (Read() == "e")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool EsitäKysymysJaTarkistaVastaus(string kysymys, double vastaus)
        {
            Console.WriteLine(kysymys);
            Console.WriteLine(vastaus);
            if (Syote() == vastaus)
            {
                Console.Clear();
                Console.WriteLine("Oikein!");
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Väärin!");
                return false;
            }
        }
        static void Main(string[] args)
        {
            bool exit = false, kokonais, minus, jakolasku;
            double answer = 0, luku1 = 0, luku2 = 0;
            Random satunnainen = new Random();
            int palkinto = 0;
            //Kokonaisluvut ja negatiiviset luvut määritellään tässä aliohjelmia hyväksikäyttäen
            kokonais = Kok();
            minus = Neg();
            jakolasku = Div();

            //ohjelma pyörii kunnes valitaan "exit"
            do
            {

                Console.WriteLine("Haluatko laskea \n1.Yhteenlaskun \n2.Jakolaskun \n3.Erotuslaskun vai \n4.Kertolaskun \n5.Määrittele kokonaisluvut ja negatiiviset luvut uudestaan\n6.Quit \nOlet voittanut {0} palkintoa tähän asti.\n{1}\n{2}", palkinto, Kokonaisluvut(kokonais), Miinus(minus));

                //Aliohjelmasta otetaan luvut
                luku1 = Randomizer(kokonais, satunnainen);
                luku2 = Randomizer(kokonais, satunnainen);

                //Jos vastaus ei voi olla negatiivinen, käännetään luvut keskenään
                if (minus == false && luku2 > luku1)
                {
                    luku1 = luku1 * luku2;
                    luku2 = luku1 / luku2;
                    luku1 = luku1 / luku2;
                }
                switch (Syote())
                    {
                    //switch case skenaario laskuja varten
                        case 1:
                            
                            answer = luku1 + luku2;

                            //pyöristetään kahdenteen desimaaliin
                            answer = Math.Round(answer, 2, MidpointRounding.AwayFromZero);
                        
                            //Aliohjelmaa käytetään vastauksen kysymiseen, palkinto lisätään, jos vastaus on oikein
                            bool meniOikein = EsitäKysymysJaTarkistaVastaus(luku1 + " + " + luku2 + " = ?", answer);
                            if (meniOikein)
                            {
                                palkinto++;
                            }
                            break;
                        case 2:

                            // Jakolasku jaetaan kahden satunnaisluvun kertomalla, jotta jakolaskusta tulisi aina jokin kokonaisluku.
                            if (jakolasku == true)
                            {
                            // Arvotaan uudet luvut aliohjelmasta jos vastaus saa olla pelkkiä kokonaislukuja

                                luku1 = Randomizer(kokonais = true, satunnainen);
                                luku2 = Randomizer(kokonais = true, satunnainen);
                                double ans1 = luku1 * luku2;
                                answer = ans1 / luku1;
                                meniOikein = EsitäKysymysJaTarkistaVastaus(ans1 + " / " + luku1 + " = ?", answer);
                            }
                            else
                            {

                                answer = luku1 / luku2;
                                answer = Math.Round(answer, 2, MidpointRounding.AwayFromZero);

                                meniOikein = EsitäKysymysJaTarkistaVastaus(luku1 + " / " + luku2 + " = ?", answer);
                            }
                            if (meniOikein) 
                                {
                                palkinto++;
                                }
                            break;
                        case 3:
                            answer = luku1 - luku2;
                            meniOikein = EsitäKysymysJaTarkistaVastaus(luku1 + " - " + luku2 + " = ?", answer);
                            if (meniOikein)
                            {
                                palkinto++;
                            }
                            break;
                        case 4:
                            answer = luku1 * luku2;
                            answer = Math.Round(answer, 2, MidpointRounding.AwayFromZero);
                            meniOikein = EsitäKysymysJaTarkistaVastaus(luku1 + " * " + luku2 + " = ?", answer);
                            if (meniOikein)
                            {
                                palkinto++;
                            }
                            break;
                        case 5:
                        
                            //Tällä voidaan vaihtaa kokonaisluvut ja negatiiviset luvut pois päältä haluttaessa
                            kokonais = Kok();
                            minus = Neg();
                            jakolasku = Div();
                            Console.Clear();
                            break;
                    case 6:

                            //Tällä poistutaan ohjelmasta
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
