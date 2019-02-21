using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Anna rahamäärä euroissa");
            string syote = Console.ReadLine();
            int raha = int.Parse(syote);
            Console.WriteLine("Haluatko kääntää (d)ollareiksi vai (p)unniksi?");
            string v = Console.ReadLine();
            if (v == "d")
            {
                Console.Write("Sinulla on {0} dollaria", raha * 1.13);
                Console.ReadKey();
            } else if (v == "p")
            {
                Console.Write("Sinulla on {0} puntaa", raha * 0.88);
                Console.ReadKey();
            } else
            {
                Console.Write("Väärä syntaksi");
                Console.ReadKey();
            }

        }
    }
}
