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
			string nimi = "";
			int ikä = 0;
			Console.WriteLine("Tervetuloa ohjelmaan. Siirry valikossa valitsemalla numero");
			Alku:
			try
			{
				Console.WriteLine("1.Anna nimesi");
				Console.WriteLine("2.Anna ikäsi");
				Console.WriteLine("3.Näytä nimesi");
				Console.WriteLine("4.Näytä ikäsi");
				Console.WriteLine("5.Poistu ohjelmasta\n");
				Console.Write("     >");
				Valikko valinta = (Valikko)int.Parse(Console.ReadLine());
				switch (valinta)
				{
					case Valikko.Name:
						Console.WriteLine("Syötä nimi:");
							nimi = Console.ReadLine();
						Console.WriteLine("Nimesi on tallennettu.");
						break;

					case Valikko.Age:
						Console.WriteLine("Syötä ikä:");
						ikä = int.Parse(Console.ReadLine());
						Console.WriteLine("Ikäsi on tallennettu.");
						break;

					case Valikko.ShowName:
						Console.WriteLine("Nimesi on: {0}", nimi);
						break;

					case Valikko.ShowAge:
						Console.WriteLine("Ikäsi on: {0}", ikä);
						break;

					case Valikko.Exit:
						Console.WriteLine("Näkemiin!");
						Console.ReadKey();
						Environment.Exit(-1);
						break;
					default:
						Console.WriteLine("Et valinnut mitään!");
						break;
				}
				goto Alku;
			}
			catch (FormatException)
			{
				Console.WriteLine("Virhe! Et syöttänyt numeroa!");
				goto Alku;
			}
			finally
			{
				Console.ReadKey();
			}

		}
	}
}
