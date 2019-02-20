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
			int arvaus;
			int oikea = 45;
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Anna luku");
				syote = Console.ReadLine();
				arvaus = int.Parse(syote);
				if (arvaus == oikea)
				{
					Console.WriteLine("Onneksi olkoon! Sama luku!");
					Console.ReadKey();
					Environment.Exit(-1);
				}
				else
				{
					Console.WriteLine("Arvasit väärin!");
				}
			}
			Console.WriteLine("5 kierrosta päättyi. Parempi onni ensi kerralla!");
			Console.ReadKey();
		}
	}
}
