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
			Console.WriteLine("Oletko (m)ies vai (n)ainen?");
			string sukup = Console.ReadLine();
            Console.WriteLine("Mikä on ikäsi?");
            string syote = Console.ReadLine();
            int age = int.Parse(syote);
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
		}
    }
}
