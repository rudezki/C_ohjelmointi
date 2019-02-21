using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_array
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			string[] fruit;
			double[] price;
			fruit = new string[3] { "Omena ", "Päärynä ", "Tomaatti " };
			price = new double[3] { 1.2, 1, 2 };

			for (int i = 0; i < fruit.Length ; i++) {
				Console.Write(fruit[i]);
				Console.Write(price[i]);
				Console.Write("€\r\n");
			}
			Console.ReadKey();
		}
	}
}
