using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_helikopteri
{
	class Program
	{
		enum Valikko { Matkustaja = 1, Laukku, Poistu }
		static void Main(string[] args)
		{

			double jaljella = 100;
			int matkustajaTila = 4;
			int matkustaja = 0;
			double kokonaisPaino = 0;
			double laukunPaino = 0;
			int laukkuMaara = 0;
			double painoParseri;
			Console.WriteLine("Lastataan helikopteri!");
			try
			{

				for (; ; )
				{
					Console.WriteLine("1.Lisää matkustaja\n2.Lisää laukku\n3. Poistu\nJäljellä oleva tila: {0} kg\nMatkustajapaikkoja jäljellä: {1}", jaljella, matkustajaTila);
					Valikko valinta = (Valikko)int.Parse(Console.ReadLine());

					switch (valinta)
					{
						case Valikko.Matkustaja:
							Console.WriteLine("Matkustaja lisätty");
							matkustaja = matkustaja + 1;
							matkustajaTila = matkustajaTila - 1;
							if (matkustajaTila < 0)
							{
								Console.WriteLine("Matkustajatilaa ei ole tarpeeksi jäljellä. Lisäys peruttu.");
								matkustaja = matkustaja - 1;
								matkustajaTila = matkustajaTila + 1;
							}
							break;

						case Valikko.Laukku:
							Console.WriteLine("Anna laukun paino:");
							painoParseri = double.Parse(Console.ReadLine());
							laukunPaino = painoParseri + kokonaisPaino;
							laukkuMaara = laukkuMaara + 1;
							jaljella = jaljella - laukunPaino;
							if (jaljella < 0)
							{
								Console.WriteLine("Paino ylittyi, laukun lisäys peruttu.");
								kokonaisPaino = kokonaisPaino + laukunPaino;
								laukkuMaara = laukkuMaara - 1;
								jaljella = jaljella + laukunPaino;
							}
							break;

						case Valikko.Poistu:
							Console.WriteLine("Näkemiin!");
							Environment.Exit(-1);
							break;
						default:
							break;
					}
				}
			}
			catch (ArrayTypeMismatchException e)
			{
				Console.WriteLine("Virhe! {0}", e.Message);
			}
			catch (FormatException e)
			{
				Console.WriteLine("Virhe! {0}", e.Message);
			}
			finally
			{
				Console.ReadKey();
			}
		}
	}
}
