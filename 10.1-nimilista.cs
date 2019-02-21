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
			int i, number;
			bool result;
			List<string> lista = new List<string>();
			Console.WriteLine("Anna nimiä (kirjoita 'quit' lopettaaksesi)");

			for (; ;)
			{
				syote = Console.ReadLine();
				if (syote == "quit")
				{
					Console.WriteLine("\n Tulostetaanko nimet (a)lku- vai (l)oppupäästä?");

					Question:
					syote = Console.ReadLine();
					lista.Sort();
					result = Int32.TryParse(syote, out number);
					if (result)
					{
						Console.WriteLine("Converted {0} to {1}.", syote, number);
					}
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
					else
					{
						Console.WriteLine("Attempted conversion of '{0}' failed", syote == null ? "<null>" : syote);
						goto Question;
					}
					Console.ReadKey();
					Environment.Exit(-1);
				}
				lista.Add(syote);
			}

		}
	}
}
