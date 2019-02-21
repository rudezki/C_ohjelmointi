using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_foreach
{
	class Program
	{
		static void Main(string[] args)
		{
			double sum1 = 0;
			double[] sarja = new double[5];
			Console.WriteLine("Anna numeroita 5 kpl");
			sarja[0] = double.Parse(Console.ReadLine());
			sarja[1] = double.Parse(Console.ReadLine());
			sarja[2] = double.Parse(Console.ReadLine());
			sarja[3] = double.Parse(Console.ReadLine());
			sarja[4] = double.Parse(Console.ReadLine());

			foreach (double x in sarja)
				{
				sum1 += x;
				}
			double average1 = sum1 / sarja.Length;
			Console.WriteLine(average1);
			Console.ReadKey();
			


		}
	}
}
