using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_lista
{
	class Program
	{
		static void Main(string[] args)
		{
			string syote;
			int i;
			List<string> lista = new List<string>();
			Console.WriteLine("Anna nimiä (kirjoita 'quit' lopettaaksesi)");
			for (; ;)
			{
				syote = Console.ReadLine();
				if (syote == "quit")
				{
					Console.WriteLine("\n Tulostetaanko nimet (a)lku- vai (l)oppupäästä?");
					syote = Console.ReadLine();
					lista.Sort();
					if (syote == "a")
					{
						for (i = 0; i < lista.Count; i++)
						{
							Console.WriteLine(lista[i]);
						}
					}
					else if (syote == "l")
					{
						lista.Reverse();
						for (i = 0; i < lista.Count; i++)
						{
							Console.WriteLine(lista[i]);
						}
					}
						Console.ReadKey();
					Environment.Exit(-1);
				}
				lista.Add(syote);
			}

		}
	}
}
