using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //string saisie = Console.ReadLine();
            //int a = int.Parse(saisie);
            //char operation = Console.ReadKey().KeyChar;
            //int b = Console.Read();

            Console.WriteLine("BASIC OPERATION :");
            ElementaryOperations.BasicOperation(7, 41, 'x');
            ElementaryOperations.BasicOperation(7, 41, '*');
            ElementaryOperations.BasicOperation(11, 2, '/');

            Console.WriteLine("INTEGER DIVISION :");
            ElementaryOperations.IntegerDivision(11, 2);

            Console.WriteLine("POW :");
            ElementaryOperations.Pow(11, 2);
            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
