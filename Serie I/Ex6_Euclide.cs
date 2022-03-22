using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Euclide
    {
        public static int Pgcd(int a, int b)
        {
            int q = 0;
            int r = 1;
           
            while(r != 0)
            {
                q = a / b;
                r = a % b;
                if (r == 0)
                {
                    return b;
                }
                else
                {
                    a = b;
                    b = r;
                }
            }
            return -1;
        }

        public static int PgcdRecursive(int a, int b)
        {
            int r = a % b;
            int q = a / b;

            if (r == 0)
            {
                return b;
            }
            else
            {
                return PgcdRecursive(b, r);
            }
        }
    }
}
