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
            int q;
            int r;
            r = a / b;
            q = a % b;
            if(r == 0)
            {
                return b;
            }
            else
            {
                a = b;
                b = r;
            }
        }

        public static int PgcdRecursive(int a, int b)
        {
            //TODO
            return -1;
        }
    }
}
