using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliohjelmat_1
{
    class Program
    {
        private static void Tervehdys(string kayttaja,int ika)
        {
            Console.WriteLine("Anna ikäsi");
            ika = int.Parse(Console.ReadLine());
            Console.WriteLine("Tervetuloa ohjelmaan, {0}, {1} vuotta", kayttaja, ika);
        }

        static void Main(string[] args)
        {
            int ika =0;
            Console.WriteLine("Anna nimesi");
            string kayttaja = Console.ReadLine();

            Tervehdys(kayttaja,ika);
            Console.ReadKey();
        }
    }
}
