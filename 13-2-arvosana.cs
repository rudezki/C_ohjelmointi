using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_arvosana
{
	class Program
	{
		static void Main(string[] args)
		{
			string syote;
			int arvosana;
			try
			{

				Console.WriteLine("Syötä arvosana (1-10)");
				syote = Console.ReadLine();
				arvosana = int.Parse(syote);
				switch (arvosana)
				{
					case 4:
						Console.WriteLine("Arvosanasi on hylätty!");
						break;
					case 5:
						Console.WriteLine("Huono arvosana!");
						break;
					case 6:
						Console.WriteLine("Välttävä arvosana!");
						break;
					case 7:
						Console.WriteLine("Tyydyttävä arvosana!");
						break;
					case 8:
						Console.WriteLine("Hyvä arvosana!");
						break;
					case 9:
						Console.WriteLine("Kiitettävä arvosana!");
						break;
					case 10:
						Console.WriteLine("Erinomainen arvosana!!!");
						break;
					default:
						Console.WriteLine("Ei ole kelvollinen arvosana. :(");
						break;
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("Vastauksesi oli väärää muotoa!");
			}
			finally
			{
				Console.ReadKey();
			}
			
		}
	}
}
