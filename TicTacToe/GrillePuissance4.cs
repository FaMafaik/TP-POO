using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTicTacToe
{
    public class GrillePuissance4
    {
        public int[,] grille = new int[4, 7];
        public int numLigne;
        public int numColonne;
        public int nbJetonsVictoire = 4;


        public bool CaseVide(int numLigne, int numColonne)
        {

            if (grille[numLigne, numColonne] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool GrilleComplete()
        {
            for (int i = 0; i < grille.GetLength(0); i++)
            {
                for (int j = 0; j < grille.GetLength(1); j++)
                {
                    if (CaseVide(i, j))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool DeposeJeton(int numColonne, int numJoueur)
        {
            bool deposeJeton = false;
            int i = grille.GetLength(0)-1;
            

            while (i>= 0 && !deposeJeton)
            {
                if(CaseVide(i,numColonne))
                {
                    grille[i, numColonne] = numJoueur;
                    numLigne = i;
                    deposeJeton =true;
                }

                --i;
            }

            

            return deposeJeton;
        }

        public bool LigneComplete(int numJoueur)
        {
            bool testLigne = false;
            int compteurJetons = 0;
    
           
                for (int j = 0; j < grille.GetLength(1); j++)
                {
                    if (grille[numLigne, j] == numJoueur)
                    {
                        compteurJetons++;
                    } else 
                    {
                        compteurJetons = 0;
                    }

                 
                    if (compteurJetons == nbJetonsVictoire)
                    {
                        testLigne = true;
                    }
                }
                
            return testLigne;
        }

        public bool ColonneComplete(int numJoueur)
        {
            bool testLigne = false;
            int compteurJetons = 0;


            for (int j = 0; j < grille.GetLength(0); j++)
            {
                if (grille[j, numColonne] == numJoueur)
                {
                    compteurJetons++;
                }
                else
                {
                    compteurJetons = 0;
                }


                if (compteurJetons == nbJetonsVictoire)
                {
                    testLigne = true;
                }
            }

            return testLigne;
        }

        public bool VictoireJoueur(int numJoueur)
        {
            if (LigneComplete(numJoueur) || ColonneComplete(numJoueur))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void AffichageGrille()
        {
            Console.WriteLine(" {0} | {1} | {2} | {3} | {4} | {5} | {6} ", grille[0, 0], grille[0, 1], grille[0, 2], 
                                                                  grille[0, 3], grille[0, 4], grille[0, 5], grille[0, 6]);
            Console.WriteLine("---+---+---+---+---+---+---");
            Console.WriteLine(" {0} | {1} | {2} | {3} | {4} | {5} | {6} ", grille[1, 0], grille[1, 1], grille[1, 2], 
                                                                   grille[1, 3], grille[1, 4], grille[1, 5], grille[1, 6]);
            Console.WriteLine("---+---+---+---+---+---+---");
            Console.WriteLine(" {0} | {1} | {2} | {3} | {4} | {5} | {6} ", grille[2, 0], grille[2, 1], grille[2, 2]
                                                                   , grille[2, 3], grille[2, 4], grille[2, 5], grille[2, 6]);
            Console.WriteLine("---+---+---+---+---+---+---");
            Console.WriteLine(" {0} | {1} | {2} | {3} | {4} | {5} | {6} ", grille[3, 0], grille[3, 1], grille[3, 2]
                                                                   , grille[3, 3], grille[3, 4], grille[3, 5], grille[3, 6]);

        }
    }

   
}
