using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliohjelmat_1
{
    class Program
    {
        private static void Tervehdys(string kayttaja)
        {
            Console.WriteLine("Tervetuloa ohjelmaan, {0}", kayttaja);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Anna nimesi");
            string kayttaja = Console.ReadLine();
            Tervehdys(kayttaja);
            Console.ReadKey();
        }
    }
}
