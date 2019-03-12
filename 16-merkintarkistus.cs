using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_merkintarkistus
{
	class Program
	{
		static void Main(string[] args)
		{
			Char merkki;
			ConsoleKeyInfo syote;

			Console.WriteLine("Syötä merkki!\n");

			syote = Console.ReadKey();
			merkki = syote.KeyChar;
			Console.WriteLine("\n");

			if (Char.IsSeparator(merkki))
			{
				Console.WriteLine("Syötit tyhjän merkin");
			}
			else if (Char.IsDigit(merkki))
			{
				Console.WriteLine("Syötit numeron: {0}", merkki);
			}
			else if (Char.IsLetter(merkki))
			{
				Console.WriteLine("Syötit kirjaimen: {0}", merkki);
			}
			else if (Char.IsPunctuation(merkki))
			{
				Console.WriteLine("Syötit merkin: {0}", merkki);
			}
			Console.ReadKey();
			}
		}
	}

