using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_array
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] fruit;
			fruit = new string[3] { "Omena", "Appelsiini", "Banaani" };
			for (int i = 0; i < fruit.Length; i++)
			{
				Console.WriteLine(fruit[i]);
			}
				Console.ReadKey();
		}
	}
}
