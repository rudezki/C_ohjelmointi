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
			int maara;
			List<string> lista = new List<string>();
			Console.WriteLine("Anna nimiä (kirjoita 'quit' lopettaaksesi)");
			for (; ;)
			{
				syote = Console.ReadLine();
				if (syote == "quit")
				{
					
					Console.WriteLine("\n Kuinka monta oppilaan nimeä haluat nähdä?");
					syote = Console.ReadLine();
					maara = int.Parse(syote);
					for (int i = 0; i < maara; i++)
					{
						Console.WriteLine(lista[i]);
					}
					Console.ReadKey();
					Environment.Exit(-1);
				}
				lista.Add(syote);
			}

		}
	}
}
