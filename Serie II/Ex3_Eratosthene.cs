using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Eratosthene
    {
        public static int[] EratosthenesSieve(int n)
        {
            int[] tableau = new int[n];
            int m = 0;
            for (int h = 0; h < n; h++)
            {
                tableau[h] = h;
            }
            for (int i = 2; i < n; i++)
            {
                if (tableau[i] != -1)
                {
                    for (int k = 2; k < n;k++)
                    {
                    
                        m = i * k;
                        if (m < n)
                        {
                            tableau[m] = -1;
                        }
                    }
                }
            }
            for (int j = 2; j < n; j++)
            {
                if (tableau[j] != -1)
                {
                    return tableau;
                }
            }
            return tableau;
        }
    }
}
