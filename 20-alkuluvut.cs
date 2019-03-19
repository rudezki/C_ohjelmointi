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
			int luku, i, p;
			Console.WriteLine("Anna luku mihin asti tulostetaan alkulukuja!");
			luku = int.Parse(Console.ReadLine());

			for (i = 2; i <= luku; i++)
			{
				for (p = 2; p <= i; p++)
				{
					if (i % p == 0)
					{
						break;
					}
				}
				if (i == p)
				{
					Console.WriteLine("{0}, ", i);
				}
			}

			Console.ReadKey();
			
			
		}
	}
}
