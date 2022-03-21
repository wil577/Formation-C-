using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Pyramid
    {
        public static void PyramidConstruction(int n, bool isSmooth)
        {
            int a = 0;
            for (int i = 1; i <= n - 1; i++)
            {
                if (isSmooth == true)
                {
                    Console.WriteLine(" ");

                    for (int h = 0; h < (n-a); h++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < (i+a); j++)
                    {
                        Console.Write("+");
                    }

                    for (int h = 0; h < n; h++)
                    {
                        Console.Write(" ");
                    }
                    a++;
                }
            }
        }
    }
}
