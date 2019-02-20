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
			int arvaus = 0;
			int oikea = 0;
			int i = 0;
			Random satunnainen = new Random();
			oikea = satunnainen.Next(1, 101);
			for ( ; ; )
			{
				Console.WriteLine("Anna luku 1:n ja 100:n väliltä (L quittaa)");
				syote = Console.ReadLine();
				if (syote == "L")
				{
					Environment.Exit(-1);
				}
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
				else 
				{
					Console.WriteLine("Arvasit väärin!");
				}
			}
		}
	}
}
