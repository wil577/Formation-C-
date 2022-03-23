using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recherche Linéaire :");
            int[] t = { -5, 10, 3, 0, 4, 2, -7 };
            int a = Search.LinearSearch(t, 2);
            Console.WriteLine(a);

            Console.WriteLine("Recherche dichotomique :");
            int[] x = { -7, -5, 0, 3, 4, 7, 10 };
            Array.Sort(t);
            int b = Search.LinearSearch(t, -6);
            Console.WriteLine(b);

            Console.WriteLine("Crible d'Era le bro :");
            int[] c = new int[100];
            c = Eratosthene.EratosthenesSieve(100);
            for (int i = 2; i < 100; i++)
            {
                if (c[i] != -1)
                {
                    Console.WriteLine(c[i]);
                }
            }

            Personne paul = new Personne("Truc", "Paul", DateTime.Today);
            Console.WriteLine(paul.Nom);

            string q1 = "Quelle est l'année du sacre de Charlemagne ?";
            string[] r1 = new string[] { "476", "800", "1066", "1789" };
            Qcm qcm1 = new Qcm(q1, r1, 1, 1);
            string q2 = "Quelle est l'année du sacre de Charlemagne ?";
            string[] r2 = new string[] { "476", "800", "1066", "1789" };
            Qcm qcm2 = new Qcm(q2, r2, 1, 1);
            Qcm[] tabQcm = new Qcm[] { qcm1, qcm2 };
            Quiz.AskQuestions(tabQcm);
            Quiz.QcmValidity(qcm1);
            //int points = Quiz.AskQuestion(qcm1);
            //Console.WriteLine(points);
            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
