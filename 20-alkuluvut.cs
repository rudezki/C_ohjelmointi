using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_alkuluvut
{
	class Program
	{
		static void Main(string[] args)
		{
			int luku;
			Console.WriteLine("Anna luku!");
			luku = int.Parse(Console.ReadLine());

			if (luku % 2 == 0)
			{
				Console.WriteLine("Numero ei ole alkuluku!");
			} else if (luku % 2 > 0)
			{
				Console.WriteLine("Numero on alkuluku!");
			}
			Console.ReadKey();
			
			
		}
	}
}
