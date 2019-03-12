using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_noppapeli
{
	class Program
	{
		static void Main(string[] args)
		{
			int i;
			int yhteisluku = 0;
			Random rnd = new Random();

			for (i = 0; i < 5; i++)
			{
				int noppa1 = rnd.Next(1, 7);
				int noppa2 = rnd.Next(1, 7);
				// Jos haluaa, että noppaluvut tulostetaan, niin:
				// Console.WriteLine("Tulos on {0} ja {1}", noppa1, noppa2);
				yhteisluku = noppa1 + noppa2 + yhteisluku;
			}

			Console.WriteLine(yhteisluku);
			Console.ReadKey();
		}
	}
}
