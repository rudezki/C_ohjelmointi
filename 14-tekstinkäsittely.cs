using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_tekstinkäsittely
{
	class Program
	{
		static void Main(string[] args)
		{
			string nimi;
			int i;
			char letter;

			try
			{
				Console.WriteLine("Anna nimi!");
				nimi = Console.ReadLine();
				char[] array = nimi.ToCharArray();
				Console.WriteLine("");

				for (i = 0; i < nimi.Length; i++)
				{
					letter = array[i];
					Console.Write(letter);
				}
				Console.Write("\n");
				for (i = 0; i < nimi.Length; i++)
				{
					letter = array[i];
					Console.Write(letter);
					Console.Write(" ");
				}
				Console.Write("\n");
				for (i = nimi.Length -1; i >= 0; i--)
				{
					letter = array[i];
					Console.Write(letter);
					Console.Write(" ");
				}


			}
			catch (FormatException e)
			{
				Console.WriteLine("Virhe! ", e.Message);
			}
			finally
			{
				Console.ReadKey();
			}
		}
	}
}
