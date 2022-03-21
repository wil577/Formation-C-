using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class PrimeNumbers
    {
        static bool IsPrime(int valeur)
        {
            for (int i = 2; i <= (int)Math.Sqrt(valeur); i++)
            {
                if (valeur % i == 0)
                {
                    return false;

                }
            }
            return true;
        }

        public static void DisplayPrimes()
        {
            // POUR CHAQUE entier i = 1; tant que i <= 100; i+=1
            //SI i est premier
            // ALORS écrire i dans console
            for(int i =1; i <= 100; i++)
            {
                bool estPremier = IsPrime(i);
                if (estPremier)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
