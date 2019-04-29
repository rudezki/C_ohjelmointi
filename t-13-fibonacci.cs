using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_Fibonacci
{
    class Program
    {
        private static long Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            if (n >= 2)
            {
                //Fibonaccin lukujen funktio on tässä
                return Fibonacci(n - 2) + Fibonacci(n - 1);
            }
            else
            {
                return 0;
            }
            
        }
        static void Main(string[] args)
        {
            int i, x;
            string syote;
            bool result;

            Console.WriteLine("Anna luku");
            syote = Console.ReadLine();
            result = Int32.TryParse(syote, out x);
            //Spämmätään x kappaletta fibonaccin lukuja
            for (i = 0; i <= x; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }

            Console.ReadKey();
        }
    }
}
