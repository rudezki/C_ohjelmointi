using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Anna luku");
			string syote = Console.ReadLine();
			int a = int.Parse(syote);
			int i;
			int k;
			Console.WriteLine("Antamasi luku on {0}", a);
			for (i = 0; i <= a; i++)
			{
				for (k = 1; k <= i; ++k)
					Console.Write(k);
				Console.Write("\n");
			}
			Console.ReadKey();
		}
	}
}
