using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliohjelmat_2
{
    class Program
    {
        private static int Pienin(int eka, int toka, int kolmas)
        {
            List<int> pienin = new List<int>() { eka, toka, kolmas };
            pienin.Sort();
            Console.WriteLine(pienin[0]);
            return pienin[0];
        }
        private static int Suurin(int eka, int toka, int kolmas)
        {
            List<int> suurin = new List<int>() { eka, toka, kolmas };
            suurin.Sort();
            Console.WriteLine(suurin[2]);
            return suurin[2];
        }

        static void Main(string[] args)
            {
            int luku1, luku2, luku3, suurinLuku, pieninLuku;
            string syote;

            Console.WriteLine("Anna eka luku:");
            syote = Console.ReadLine();
            luku1 = int.Parse(syote);
            Console.WriteLine("Anna toka luku:");
            syote = Console.ReadLine();
            luku2 = int.Parse(syote);
            Console.WriteLine("Anna kolmas luku:");
            syote = Console.ReadLine();
            luku3 = int.Parse(syote);
            pieninLuku = Pienin(luku1, luku2, luku3);
            suurinLuku = Suurin(luku1, luku2, luku3);
            Console.ReadLine();
        }
    }
}
