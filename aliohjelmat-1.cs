using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliohjelmat_1
{
    class Program
    {
        //Aliohjelma kysyy nimen ja iän ja palauttaa ne.
        private static void Tervehdys()
        {
            Console.WriteLine("Anna nimesi")
            string kayttaja = Console.ReadLine();
            Console.WriteLine("Anna ikäsi");
            int ika = int.Parse(Console.ReadLine());
            Console.WriteLine("Tervetuloa ohjelmaan, {0}, {1} vuotta", kayttaja, ika);
        }

        static void Main(string[] args)
        {
            Tervehdys();
            Console.ReadKey();
        }
    }
}
