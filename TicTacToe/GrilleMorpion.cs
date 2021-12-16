using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTicTacToe
{
    public class GrilleMorpion
    {

        public int[,] grille = new int[3, 3];
        public int numLigne;
        public int numColonne;
        public int nbJetonsVictoire = 3;


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
            for(int i = 0; i < grille.GetLength(0); i++)
            {
                for(int j = 0; j < grille.GetLength(1); j++)
                {
                    if(CaseVide(i,j))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        
        public int DeposeJeton(int numLigne, int numColonne, int numJoueur)
        {
            grille[numLigne, numColonne] = numJoueur;

            return grille[numLigne, numColonne];
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

        public bool DiagonaleComplete(int numJoueur)
        {
            if(grille[0, 0] == numJoueur && grille[1,1] == numJoueur && grille[2,2] == numJoueur)
            {
                return true;
            } else if(grille[0,2] == numJoueur && grille[1,1] == numJoueur && grille[2,0] == numJoueur){
                return true;
            } else{
                return false;
            }
        }

        public bool VictoireJoueur(int numJoueur)
        {
            if(LigneComplete(numJoueur) || ColonneComplete(numJoueur) || DiagonaleComplete(numJoueur)) {
                return true;
            } else
            {
                return false;
            }
        }

        public void AffichageGrille()
        {
            Console.WriteLine(" {0} | {1} | {2} ", grille[0,0], grille[0,1], grille[0,2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", grille[1, 0], grille[1, 1], grille[1,2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", grille[2, 0], grille[2, 1], grille[2, 2]);
        }
    }
}
