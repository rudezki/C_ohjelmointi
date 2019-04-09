using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, quest, color;

            Console.WriteLine("WHAT... is your name?");
            name = Console.ReadLine();
            Console.WriteLine("WHAT... is your quest?");
            quest = Console.ReadLine();
            Console.WriteLine("WHAT... is your favorite color?");
            color = Console.ReadLine();

            Console.Write("Hello, {0}, who {1} and whose favorite color is {2}!", name, quest, color);
            Console.ReadKey();
        }
    }
}
