using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public struct Personne
    {
        public string Nom;
        public string Prenom;
        public DateTime DateDeNaissace;

        public Personne(string nom, string pnom, DateTime dateDeNaissace)
        {
            Nom = nom;
            Prenom = pnom;
            DateDeNaissace = dateDeNaissace;
        }
    }

    public struct Qcm
    {
        public string Question;
        public string[] Reponse;
        public int Solution;
        public int Point;

        public Qcm(string qst, string[] reponse, int solution, int point)
        {
            Question = qst;
            Reponse = reponse;
            Solution = solution;
            Point = point;
        }
    }

    public static class Quiz
    {
        public static void AskQuestions(Qcm[] qcms)
        {
            int points = 0;
            for(int i = 0; i < qcms.Length; i++)
            {
                points += AskQuestion(qcms[i]);
            }
            Console.WriteLine(points);
        }

        public static int AskQuestion(Qcm qcm)
        {
            int points = 0;
            if (QcmValidity(qcm) == true)
            {
                //poser question
                Console.WriteLine(qcm.Question);
                //afficher reponse possible
                for(int i = 0; i < qcm.Reponse.Length; i++)
                {
                    Console.Write((i+1) +". " + qcm.Reponse[i]+ " ");
                }
                //demande reponse  
                Console.WriteLine(); 
                string rep = Console.ReadLine();
                int ans;
                int.TryParse(rep,out ans);

                //si reponse bonne donner point sinon donne 0
                if (ans == qcm.Solution+1)
                {
                    points = qcm.Point + points;
                }
                else
                {
                    //donne 0 points
                }
                return points;   
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static bool QcmValidity(Qcm qcm)
        {
            if (qcm.Reponse.Length > 0 && 0 <= qcm.Solution && qcm.Solution < qcm.Reponse.Length)
            {
                return true;
            }

            return false;
        }
    }
}
