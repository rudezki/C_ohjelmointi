using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Paistaako aurinko? (K/E)");
			string aurinko = Console.ReadLine();
			Console.WriteLine("Sataako? (K/E)");
			string sade = Console.ReadLine();
			Console.WriteLine("Onko lämpötila > 0? (K/E)");
			string lampo = Console.ReadLine();

			if (aurinko == "K" && sade == "K" && lampo == "K")
			{
				Console.Write("Aurinko paistaa ja vettä sataa, taitaa tulla kesä.");
				Console.ReadKey();
			}
			else if (aurinko == "E" && sade == "K" && lampo == "K")
			{
				Console.Write("Syksy saapui, lehdet vei tuuli mennessään.");
				Console.ReadKey();
			}
			else if (sade == "E" && lampo == "K")
			{
				Console.Write("Jo joutui armas aika ja suvi suloinen");
				Console.ReadKey();
			}
			else if (aurinko == "E" && sade == "E" && lampo == "E")
			{
				Console.Write("Joulu tulee!");
				Console.ReadKey();
			}
			else if (sade == "E" && lampo == "E")
			{
				Console.Write("Taitaa olla jo tammikuu..");
				Console.ReadKey();
			}
		}
	}
}
