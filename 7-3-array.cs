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
			Console.OutputEncoding = Encoding.UTF8;
			double[] tuoteHinta = new double[3] { 1.45, 3.40, 2 };
			int[] tuoteLkm = new int[3] { 45, 30, 17 } ;
			string[] tuoteNimi = new string[3] { "Omena", "Ananas", "Vesimeloni" };
			for (int i = 0; i < tuoteNimi.Length; i++)
			{
				Console.WriteLine();
				Console.Write("{0} yhteishinta on {1}€",tuoteNimi[i],tuoteHinta[i]*tuoteLkm[i]);
			}
			Console.ReadKey();
		


		}
	}
}
