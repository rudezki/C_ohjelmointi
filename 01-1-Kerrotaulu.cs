using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i < 11; i++) {

                Console.WriteLine("{0} * 5 = {1}" , i , i*5);
            };
            Console.ReadKey();
        }
    }
}
