using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class ElementaryOperations
    {
        public static void BasicOperation(int a, int b, char operation)
        {
            int resultat;


            if (operation == '+')
            {
                resultat = a + b;
                Console.WriteLine(a + " + " + b + " = " + resultat);
            }

            else if (operation == '-')
            {
                resultat = a - b;
                Console.WriteLine(a + " - " + b + " = " + resultat);
            }

            else if (operation == '*')
            {
                resultat = a * b;
                Console.WriteLine(a + " * " + b + " = " + resultat);
            }

            else if (operation == '/')
            {
                resultat = a / b;
                Console.WriteLine(a + " / " + b + " = " + resultat);
            }

            else
            {
                Console.WriteLine(a + operation + b + " = " + "operation invalide");
            }

            Console.WriteLine();
        }

        public static void IntegerDivision(int a, int b)
        {
            int r;
            int q;

            if (b == 0)
            {
                Console.WriteLine(a + " / " + b + " = operation invalide");
            }
            else
            {
                r = a / b;
                q = a % b;
                Console.WriteLine(a + " = " + r + " * " + b + " + " + q);
            }

        }

        public static void Pow(int a, int b)
        {
            int resultat = 1;
            resultat = (int)Math.Pow(a, b);
            Console.WriteLine(a + " ^ " + b + " = " + resultat);

            if (b < 0)
            {
                Console.WriteLine(a + " ^ " + b + " = operation invalide");
            }
        }
    }
}
