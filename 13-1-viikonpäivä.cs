using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_viikonpäivä
{
	class Program
	{
		static void Main(string[] args)
		{
			string syote;
			try
			{
				Console.WriteLine("Syötä päivän numero (1-7)");
				syote = Console.ReadLine();
				int paeva = int.Parse(syote);

				switch (paeva)
				{
					case 1:
						Console.WriteLine("Maanantai");
						break;
					case 2:
						Console.WriteLine("Tiistai");
						break;
					case 3:
						Console.WriteLine("Keskiviikko");
						break;
					case 4:
						Console.WriteLine("Torstai");
						break;
					case 5:
						Console.WriteLine("Perjantai");
						break;
					case 6:
						Console.WriteLine("Lauantai");
						break;
					case 7:
						Console.WriteLine("Sunnuntai");
						break;
					default:
						Console.WriteLine("Syötit väärän numeron!");
						break;
				}
			}
			catch (FormatException e)
			{
				Console.WriteLine("Et syöttänyt numeroa!");
			}
			finally
			{
				Console.ReadKey();
			}
		}
	}
}
