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
				char[] array = nimi.ToCharArray(); //Lisätään ohjelmaan tapa, jolla paikannetaan a-kirjain ja katsotaan, onko se olemassa nimessä.
				if (nimi.Contains("a")) {
					Console.WriteLine("Nimi sisältää pienen a-kirjaimen");
					Console.WriteLine("Annetussa nimessä 'a' on {0}. kirjain.", nimi.IndexOf("a") + 1);
					Console.WriteLine("");
				} else {
					Console.WriteLine("Nimi ei sisällä pientä a-kirjainta");
					Console.WriteLine("");
				}


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
