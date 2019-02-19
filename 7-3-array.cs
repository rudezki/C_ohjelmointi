using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3_array
{
	class Program
	{
		static void Main(string[] args)
		{
			string syote;
			int addProduct;
			Console.WriteLine("Kuinka monta tuotetta lisätään?");
			syote = Console.ReadLine();
			addProduct = int.Parse(syote);
			Console.OutputEncoding = Encoding.UTF8;
			double[] tuoteHinta = new double[addProduct];
			int[] tuoteLkm = new int[addProduct];
			string[] tuoteNimi = new string[addProduct];

			for (int i = 0; i < addProduct; i++)
			{
				Console.WriteLine("Anna tuotteen {0} nimi:", i+1);
				syote = Console.ReadLine();
				tuoteNimi[i]= syote;
				Console.WriteLine("Anna tuotteen {0} hinta:", i+1);
				syote = Console.ReadLine();
				tuoteHinta[i] = double.Parse(syote);
				Console.WriteLine("Anna tuotteen {0} lukumäärä:", i+1);
				syote = Console.ReadLine();
				tuoteLkm[i] = int.Parse(syote);
				Console.Write("Tuotteen {0} yhteishinta on {1}€\r\n",tuoteNimi[i],tuoteHinta[i]*tuoteLkm[i]);
			}
			Console.ReadKey();
		


		}
	}
}
