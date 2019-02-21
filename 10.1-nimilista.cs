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
			List<string> lista = new List<string>();
			Console.WriteLine("Anna nimiä (kirjoita 'quit' lopettaaksesi)");
			for (; ;)
			{
				syote = Console.ReadLine();
				if (syote == "quit")
				{
					Console.WriteLine("\n");
					lista.ForEach(el => Console.WriteLine(el));
					Console.ReadKey();
					Environment.Exit(-1);
				}
				lista.Add(syote);
			}

		}
	}
}
