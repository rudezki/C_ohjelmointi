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
			Console.OutputEncoding = Encoding.UTF8;
			double[] tuoteHinta = new double[3];
			int[] tuoteLkm = new int[3];
			string[] tuoteNimi = new string[3];
			for (int i = 0; i < tuoteNimi.Length; i++)
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
