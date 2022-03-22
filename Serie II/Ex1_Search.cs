using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Search
    {
        public static int LinearSearch(int[] tableau, int valeur)
        {
            for(int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i] == valeur)
                    {
                        Console.WriteLine(tableau[i]);
                    }
            }
            return -1;
        }

        public static int BinarySearch(int[] tableau, int valeur)
        {
            //TODO
            return -1;
        }
    }
}
