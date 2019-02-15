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
			int i = int.Parse(syote);
			int a = 1;
			for (a = 1; a <= 10; a += 2)
			{
				Console.WriteLine("{0}", i * a);
			}
			Console.ReadKey();
		}
	}
}
