using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_14_Huutokauppa
{
    class Program
    {
        //Tiedonsyötölle aliohjelma
        private static int Read()
        {
            bool result;
            int number;
            string syote;
            syote = Console.ReadLine();
            result = Int32.TryParse(syote, out number);
            return number;
        }
        //Simuloidaan huutokauppaa ensin huutojen määrällä, sitten korotusten suuruudella
            private static double HuutoKauppa(double bid)
        {
            int i;
            Random noppa = new Random();
            double huudot, final = 0, korotus, korotukset = 0;
            huudot = noppa.Next(0,5);
            
            for (i = 0; i < huudot; i++)
            {
                korotus = noppa.Next(105, 200);
                korotukset = (korotus/100)*bid + korotukset;
            }
            final = korotukset;
            return final;
        }
        static void Main(string[] args)
        {
            bool exit = false;
            int valinta, myydyt = 0, i;
            string syote, kalleinEsine = "paska";
            double tavoite, maxValue = double.MinValue, total = 0, jaljella;
//Listataan esineet, niiden hinnat ja huutokaupan jälkeiset hinnat esineille.
            List<double> loppuhinnat = new List<double>();
            List<string> esineet = new List<string>();
            List<double> hinnat = new List<double>();
            Console.WriteLine("Syötä huutokaupan tavoitesumma:");
            tavoite = Read();
            Console.Clear();
            do
            {
                Console.Write("Valikko\n1. Lisää tuote\n2. Aloita huutokauppa\n3. Vaihda tavoitetta.\n4. Tyhjennä kaikki.\n5. Poistu ohjelmasta.\nNykyinen tavoite: {0}\n", tavoite);
                valinta = Read();
                switch (valinta)
                {
//Syötetään esine ja sen hinta huutokaupalle, tämän kohdan voi tehdä niin monta kertaa kuin haluaa
                    case 1:

                        Console.WriteLine("Esineen nimi:");
                        syote = Console.ReadLine();
                        esineet.Add(syote);
                        Console.WriteLine("Esineen hinta:");
                        hinnat.Add(Read());
                        break;
                        //Aloitetaan huutokauppa
                    case 2:

                        for (i = 0; i < esineet.Count; i++)
                        {
                            double loppuhinta = HuutoKauppa(hinnat[i]);
                            loppuhinnat.Add(loppuhinta);
                            Console.WriteLine("Esine: {0}", esineet[i]);
                            Console.WriteLine("Hinta: {0}", loppuhinta);
                            //Jos hinta ei ole 0 niin esine on myyty, joten voidaan lisätä myyty esine.
                            if (loppuhinta != 0)
                            {
                                myydyt++;
                            }
                                Console.WriteLine("Artikkeleja myyty: {0} kpl", myydyt);
                            //Jos ei ole ensimmäinen tuote, joka on myyty.
                            if (i != 0)
                            {
                                //Verrataan edellisen tuotteen hintaan ja kerrotaan onko se halvempi vai kalliimpi
                                if (loppuhinta > HuutoKauppa(hinnat[i - 1]))
                                {
                                    Console.WriteLine("Edellinen tuote {0} on halvempi kuin uusi tuote", esineet[i-1]);
                                }
                                else if (loppuhinta < HuutoKauppa(hinnat[i - 1]))
                                {
                                    Console.WriteLine("Edellinen tuote {0} on kalliimpi kuin uusi tuote", esineet[i-1]);
                                }
                                
                            }
                            //määritetään kokonaishinta kaikille tuotteille ja verrataan tavoitteeseen
                            total = loppuhinnat.Sum();
                            jaljella = tavoite - total;
                            if (tavoite > total)
                            {
                                Console.WriteLine("Tavoitteesta on jäljellä {0} euroa", jaljella);
                            } 
                            // Jos tuotteen loppuhinta on suurempi kuin nykyinen suurin hinta, siitä tuotteesta tulee kallein tuote.
                                if (loppuhinta > maxValue)
                            {
                                maxValue = loppuhinta;
                                kalleinEsine = esineet[i];
                            }
                        }
                        Console.WriteLine("Kallein myyty artikkeli oli {0} hintaan {1} euroa", kalleinEsine, maxValue);
                        if (total < tavoite)
                        {
                            Console.WriteLine("Tavoite ei täyttynyt :(");
                        } else if (tavoite <= total)
                        {
                            Console.WriteLine("Tavoite täyttyi!");
                        }
                        break;
                    case 3:
                        //Tällä voidaan tehdä uusi tavoite
                        Console.WriteLine("Syötä uusi tavoite");
                        tavoite = Read();
                        break;
                    case 4:
                        //Poistetaan muistista kaikki
                        hinnat.Clear();
                        esineet.Clear();
                        loppuhinnat.Clear();
                        myydyt = 0;
                        total = 0;
                        jaljella = 0;
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
