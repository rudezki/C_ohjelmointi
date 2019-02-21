using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna pituutesi senttimetreinä:");
            string syote = Console.ReadLine();
            int i = int.Parse(syote);
            decimal m;
            decimal ml;
            decimal j;
            decimal t;
            m = i / 100.0f;
            ml = i / 160934.9f;
            j = i / 91.4f;
            t = i / 2.54f;
            Console.Write("Olet {0} metriä, {1} mailia, {2} jaardia ja {3} tuumaa pitkä." , MessageBox.Show(m.ToString("#.##")), MessageBox.Show(ml.ToString("#.##")), Math.Round(j , 2), MessageBox.Show(String.Format("{0:0.00}", t));
            Console.ReadKey();
        }
    }
}
