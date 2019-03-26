using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikätutka
{
    class Program
    {
        private static string SukuPuoli()
        {
            Console.WriteLine("Oletko (m)ies vai (n)ainen? Poistu ohjelmasta painamalla 'q'");
            string sukup = Console.ReadLine();
            return sukup;
        }
        private static int IkaTesti()
        {
            int age;
            Console.WriteLine("Mikä on ikäsi?");
            age = int.Parse(Console.ReadLine());
            return age;

        }
        static void Main(string[] args)
        {
            for (; ; )
            {
                int age = IkaTesti();
                string sukup = SukuPuoli();

                if (sukup == "m" && age < 13)
                {
                    Console.Write("Mitä poitsu?");
                    Console.ReadKey();
                }
                else if (sukup == "m" && age > 13 && age < 26)
                {
                    Console.Write("Mitä nuorimies");
                    Console.ReadKey();
                }
                else if (sukup == "m" && age > 25 && age < 57)
                {
                    Console.Write("Mies parhaassa iässä");
                    Console.ReadKey();
                }
                else if (sukup == "n" && age < 13)
                {
                    Console.Write("Mitä tyllerö?");
                    Console.ReadKey();
                }
                else if (sukup == "n" && age > 13 && age < 26)
                {
                    Console.Write("Mitä nuori naikkonen?");
                    Console.ReadKey();
                }
                else if (sukup == "n" && age > 25 && age < 57)
                {
                    Console.Write("Nainen kauneimmillaan");
                    Console.ReadKey();
                }
                else if (age > 56)
                {
                    Console.Write("Vanheneminen on kaunista");
                    Console.ReadKey();
                }
                else if (age < 0)
                {
                    Console.WriteLine("Et voi olla nuorempi kuin 0!");
                }
                else if (sukup == "q")
                {
                    Environment.Exit(-1);
                }

            }
		}
    }
}
