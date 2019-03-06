using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_5_1_nimijaikä
{
	class Program
	{

		enum Valikko {Name = 1, Age, ShowName, ShowAge, Exit};
		static void Main(string[] args)
		{
			int valinta;
			Valikko nimi = Valikko.Name;
			Valikko ikä = Valikko.Age;
			Valikko showname = Valikko.ShowName;
			Valikko showage = Valikko.ShowAge;
			Valikko exit = Valikko.Exit;

			Alku:
			try
			{
				Console.WriteLine("1.Anna nimesi");
				Console.WriteLine("2.Anna ikäsi");
				Console.WriteLine("3.Näytä nimesi");
				Console.WriteLine("4.Näytä ikäsi");
				Console.WriteLine("5.Poistu ohjelmasta");
				valinta = int.Parse(Console.ReadLine());
				switch (valinta)
				{
					case Valikko.Name:
						Console.WriteLine("Syötä nimi:");
							nimi = Console.ReadLine();
						break;

					case Valikko.Age:
						Console.WriteLine("Syötä ikä:");
						ikä = int.Parse(Console.ReadLine());
						break;

					case Valikko.ShowName:
						Console.WriteLine("Nimesi on: {0}", showname);
						break;

					case Valikko.ShowAge:
						Console.WriteLine("Ikäsi on: {0}", showage);
						break;

					case Valikko.Exit:
						Console.WriteLine("Näkemiin!");
						Environment.Exit(-1);
						break;
				}
				goto Alku;
			}
			catch (FormatException)
			{
				Console.WriteLine("Virhe! Et syöttänyt numeroa!");
			}
			finally
			{
				Console.ReadKey();
			}

		}
	}
}
