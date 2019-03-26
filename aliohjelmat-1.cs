using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliohjelmat_1
{
    class Program
    {
        private static void Tervehdys(string kayttaja,string suku)
        {
            Console.WriteLine("Tervetuloa ohjelmaan, {0} {1}", kayttaja, suku);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Anna nimesi");
            string kayttaja = Console.ReadLine();
            Console.WriteLine("Anna sukunimesi:");
            string suku = Console.ReadLine();

            Tervehdys(kayttaja, suku);
            Console.ReadKey();
        }
    }
}
