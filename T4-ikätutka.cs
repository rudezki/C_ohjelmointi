using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikätutka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mikä on ikäsi?");
            string syote = Console.ReadLine();
            int age = int.Parse(syote);
            if (age < 13)
            {
                Console.Write("Mitä poitsu?");
                Console.ReadKey();
            } else if (age > 13 && age < 26) {
                Console.Write("Mitä nuorimies");
                Console.ReadKey();
            } else if (age > 25 && age < 57)
            {
                Console.Write("Mies parhaassa iässä");
                Console.ReadKey();
            }
        }
    }
}
