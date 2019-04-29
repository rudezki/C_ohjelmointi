using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_15_Palindromitarkistin
{
    class Program   
    {
        //Tällä aliohjelmalla voidaan poistaa välimerkkejä ja muuntaa muuttuja pikkukirjaimiksi
        private static string Convert(string palindromi)
        {
            string valmis = palindromi;
            string returni = valmis.ToLower();
            for (int i = 0; i < returni.Length; i++)
            {
                returni = returni.Replace(",", "");
                returni = returni.Replace(".", "");
                returni = returni.Replace("!", "");
                returni = returni.Replace(" ", "");
                returni = returni.Replace(";", "");
            }
            return returni;
        }
        //Tämä ohjelma kääntää muuttujan toisinpäin
        private static string Kaannos(string palindromi)
        {
            //Siirretään kirjaimet taulukkoon jotta ne voidaan kääntää.
            char[] chars = palindromi.ToCharArray();
            for (int i = 0, j = palindromi.Length - 1; i < j; i++, j--)
            {
                
                chars[i] = palindromi[j];
                chars[j] = palindromi[i];
            }
            return new string(chars);
        }
        static void Main(string[] args)
        {
            string syote, lause;

            Console.WriteLine("Palindromintarkistaja");
            Console.WriteLine("Anna lause");
            syote = Console.ReadLine();
            lause = Convert(syote);
            //Verrataan lauseita keskenään
            if (lause == Kaannos(lause))
            {
                Console.WriteLine("Lause on palindromi");
            } else
            {
                Console.WriteLine("Lause ei ole palindromi");
            }
            Console.ReadKey();
        
        }
    }
}
