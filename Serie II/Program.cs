using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recherche Linéaire :");
            Search.LinearSearch({ -5, 0, 1, 3, 5, 8},5);
            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
