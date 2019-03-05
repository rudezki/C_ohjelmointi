using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_trycatch
{
	class Program
	{
		static void Main(string[] args)
		{
			string syote;
			int luku, jako;


			try
			{
				Console.WriteLine("Syötä jaettava luku");
				syote = Console.ReadLine();
				luku = int.Parse(syote);

				Console.WriteLine("Syötä jakaja");
				syote = Console.ReadLine();
				jako = int.Parse(syote);

				int tulos = luku / jako;
				Console.WriteLine("Jakosuhde on {0}", tulos);
				Console.ReadKey();
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("Virhe! {0}", e.Message);
			}
			catch (FormatException e)
			{
				Console.WriteLine("Virhe! {0}", e.Message);
			}
			finally
			{
				Console.WriteLine("Kiitos kun käytit hienoa ohjelmaani! Näkemiin!");
				Console.ReadKey();
			}
		}
	}
}
