using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_While
{
	class Program
	{
		static void Main(string[] args)
		{
			string syote;
			int numero = 0;
			int result = 0;
			int i = 0 + numero;
			while ( result < 100) {
				Console.WriteLine("Anna numero yhteenlaskua varten");
				syote = Console.ReadLine();
				numero = int.Parse(syote);
				result = numero + i + result;
				Console.WriteLine(result);
			}
			Console.WriteLine("Luku meni yli sadan.");
			Console.ReadKey();
		}
	}
}
