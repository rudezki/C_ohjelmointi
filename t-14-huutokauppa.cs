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
            Random noppa = new Random();
            int huudot, final = 0, korotus;
            huudot = noppa.Next(0,5);
            korotus = noppa.Next(105, 150);
            final = (huudot * korotus) / 100;
            return final;
        }
       /* private static double Edellinen(double edellinen)
        {

        }*/
        static void Main(string[] args)
        {
            bool exit = false;
            int tavoite, valinta, i;
            string syote;

            List<string> esineet = new List<string>();
            List<double> hinnat = new List<double>();
            Console.WriteLine("Syötä huutokaupan tavoitesumma:");
            tavoite = Read();
            Console.Clear();
            do
            {
                Console.Write("Valikko\n1. Lisää tuote\n2. Aloita huutokauppa\n3. Vaihda tavoitetta.\n4. Poistu ohjelmasta.\nNykyinen tavoite: {0}", tavoite);
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

                        for (i = 0; i == esineet.Count; i++)
                        {
                            Console.WriteLine("Esine: {0}",esineet[i]);
                            Console.WriteLine("Hinta: {0}",HuutoKauppa(hinnat[i]));
                        }
                        break;
                    case 3:
                        Console.WriteLine("Syötä uusi tavoite");
                        tavoite = Read();
                        break;
                    case 4:
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
