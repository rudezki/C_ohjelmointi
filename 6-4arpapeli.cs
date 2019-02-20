using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4forloop
{
	class Program
	{
		static void Main(string[] args)
		{
			string syote;
			int arvaus, oikea;
			Random satunnainen = new Random();
			oikea = satunnainen.Next(1, 101);
			for (int i = 0; i < 21; i++)
			{
				Console.WriteLine("Anna luku 1:n ja 100:n väliltä");
				syote = Console.ReadLine();
				arvaus = int.Parse(syote);
				if (arvaus == oikea)
				{
					Console.WriteLine("Onneksi olkoon! Sama luku!");
					Console.ReadKey();
					Environment.Exit(-1);
				}
				else if (i == 20)
				{
					Console.WriteLine("Et onnistunut, luku oli {0}!", oikea);
				}
				else {
					Console.WriteLine("Arvasit väärin!");
				}
			}
			Console.ReadKey();
		}
	}
}
