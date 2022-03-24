using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public static class ClassCouncil
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">CHEMIN du fichier d'entrée</param>
        /// <param name="output">CHEMIN du fichier de sortie</param>
        public static void SchoolMeans(string input, string output)
        {
            Dictionary<string, List<float>> matieres = new Dictionary<string, List<float>>();
            //prendre les valeurs d'entrées du fichier
            using (StreamReader fichierEntree = new StreamReader(input))
            {
                while (!fichierEntree.EndOfStream)
                {
                    string ligneFichierEntree = fichierEntree.ReadLine();
                    //les mettre dans un tableau
                    //Séparer les champs
                    string[] ligne1 = ligneFichierEntree.Split(';');
                    if (matieres.ContainsKey(ligne1[1]))
                    {
                        matieres[ligne1[1]].Add(float.Parse(ligne1[2]));
                    }
                    else
                    {
                        matieres.Add(ligne1[1], new List<float>() { float.Parse(ligne1[2]) });
                    }
                }
            }
            using (StreamWriter fichierSortie = new StreamWriter(output))
            {
                foreach (KeyValuePair<string, List<float>> matiere in matieres)
                {
                    float moyenne;
                    float sum = 0; 
                    //parcoure matiere.Value pour calculer la moyenne
                    foreach (float note in matiere.Value)
                    {
                        sum += note;
                    }
                    // moyenne = condition ? si c'est vrai : si c'est faux
                    moyenne = matiere.Value.Count == 0 ? 0 : sum / matiere.Value.Count;
                    fichierSortie.WriteLine(matiere.Key+";" + moyenne);
                }
            }
            //
            //calcul moyenne
            //ecrire dans le fichier de sortie
        }
    }
}
