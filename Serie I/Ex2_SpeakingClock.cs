using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class SpeakingClock
    {
        public static string GoodDay(int heure)
        {
            if (0 <= heure && heure > 6)
            {
                Console.WriteLine("Il est" + heure + "H , Merveilleuse nuit !");
            }

            if (6 <= heure && heure > 12)
            {
                Console.WriteLine("Il est" + heure + "H , Bonne matinée !");
            }

            if ( heure == 12)
            {
                Console.WriteLine("Il est" + heure + "H , Bon appétit !");
            }

            if (13 <= heure && heure > 18)
            {
                Console.WriteLine("Il est" + heure + "H , Profitez de votre après-midi !");
            }

            if (18 <= heure && heure > 24)
            {
                Console.WriteLine("Il est" + heure + "H , Passez une bonne soirée !");
            }
            return string.Empty;
        }
    }
}
