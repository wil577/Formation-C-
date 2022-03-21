using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Factorial
    {
        public static int Factorial_(int n)
        {
            int resultat = 1;
            for(int i =0; i < n; i++)
            {
                resultat = resultat * (n - i);           
            }
            return resultat;
        }

        public static int FactorialRecursive(int n)
        {
            if (n >= 1)
            {
                    return n * FactorialRecursive(n - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
