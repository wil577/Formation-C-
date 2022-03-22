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
            bool isSmooth = true;
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

            Console.WriteLine("Good day :");
            SpeakingClock.GoodDay(11);

            Console.WriteLine("Pyramide :");
            Pyramid.PyramidConstruction(15, isSmooth);

            Console.WriteLine("Factorial :");
            int res1=  Factorial.Factorial_(5);
            Console.WriteLine(res1);

            Console.WriteLine("Factorial Recursive :");
            int res2 = Factorial.FactorialRecursive(5);
            Console.WriteLine(res2);

            Console.WriteLine("Nombres premiers :");
            PrimeNumbers.DisplayPrimes();

            Console.WriteLine("algorithme d'Euclide :");
            int res3 = Euclide.Pgcd(1925,1275);
            Console.WriteLine(res3);

            Console.WriteLine("");
            Console.WriteLine("algorithme d'Euclide :");
            Console.WriteLine(Euclide.PgcdRecursive(1925, 1275));

            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
