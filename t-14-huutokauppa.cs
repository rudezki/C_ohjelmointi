using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_14_Huutokauppa
{
    class Program
    {
        private static int Read()
        {
            bool result;
            int number;
            string syote;
            syote = Console.ReadLine();
            result = Int32.TryParse(syote, out number);
            return number;
        }
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
       /* private static double Edellinen(double edellinen)
        {

        }*/
        static void Main(string[] args)
        {
            bool exit = false;
            int valinta, myydyt = 0, i;
            string syote, kalleinEsine = "paska";
            double tavoite, maxValue = double.MinValue, total = 0, jaljella;

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

                    case 1:

                        Console.WriteLine("Esineen nimi:");
                        syote = Console.ReadLine();
                        esineet.Add(syote);
                        Console.WriteLine("Esineen hinta:");
                        hinnat.Add(Read());
                        break;
                    case 2:

                        for (i = 0; i < esineet.Count; i++)
                        {
                            double loppuhinta = HuutoKauppa(hinnat[i]);
                            loppuhinnat.Add(loppuhinta);
                            Console.WriteLine("Esine: {0}", esineet[i]);
                            Console.WriteLine("Hinta: {0}", loppuhinta);
                            if (loppuhinta != 0)
                            {
                                myydyt++;
                            }
                                Console.WriteLine("Artikkeleja myyty: {0} kpl", myydyt);
                            if (i != 0)
                            {
                                if (loppuhinta > HuutoKauppa(hinnat[i - 1]))
                                {
                                    Console.WriteLine("Edellinen tuote {0} on halvempi kuin uusi tuote", esineet[i-1]);
                                }
                                else if (loppuhinta < HuutoKauppa(hinnat[i - 1]))
                                {
                                    Console.WriteLine("Edellinen tuote {0} on kalliimpi kuin uusi tuote", esineet[i-1]);
                                }
                                
                            }
                            total = loppuhinnat.Sum();
                            jaljella = tavoite - total;
                            if (tavoite > total)
                            {
                                Console.WriteLine("Tavoitteesta on jäljellä {0} euroa", jaljella);
                            } 
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
                        Console.WriteLine("Syötä uusi tavoite");
                        tavoite = Read();
                        break;
                    case 4:
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
