using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku");
            string syote = Console.ReadLine();
            int i = int.Parse(syote);
            int a;
            for (a = 1; a < 11; a++)
            {
                Console.WriteLine("{0} * {1} = {2}   {0} / {1} = {3}  {0} % {1} = {4} ", a, i, i * a, i / a, i % a);
            };
            Console.ReadKey();
                
        }
    }
}
