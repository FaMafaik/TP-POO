using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTicTacToe
{
    public class GrilleMorpion
    {

        public static int[,] grille = new int[3, 3];
    


        public bool CaseVide(int numLigne, int numColonne)
        {
           
            if(grille[numColonne, numLigne] == 0)
            {
                return true;
            } else {
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
        
        public int deposeJeton(int numLigne, int numColonne, int numJoueur)
        {
            grille[numColonne, numLigne] = numJoueur;

            return grille[numColonne, numLigne];
        }

      

        public bool ligneComplete(int numJoueur)
        {
            if (grille[0, 0] == numJoueur && grille[1, 0] == numJoueur && grille[2, 0] == numJoueur)
            {
                return true;
            }
            else if (grille[0, 1] == numJoueur && grille[1, 1] == numJoueur && grille[2, 1] == numJoueur)
            {
                return true;
            }
            else if (grille[0, 2] == numJoueur && grille[1, 2] == numJoueur && grille[2, 2] == numJoueur)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool colonneComplete(int numJoueur)
        {
            
            if (grille[0, 0] == numJoueur && grille[0, 1] == numJoueur && grille[0, 2] == numJoueur)
            {
                return true;
            }
            else if (grille[1, 0] == numJoueur && grille[1, 1] == numJoueur && grille[1, 2] == numJoueur)
            {
                return true;
            }
            else if (grille[2, 0] == numJoueur && grille[2, 1] == numJoueur && grille[2, 2] == numJoueur)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool diagonaleComplete(int numJoueur)
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
            if(ligneComplete(numJoueur) || colonneComplete(numJoueur) || diagonaleComplete(numJoueur))
            {
                return true;
            } else {
                return false;
            }
        }

        public void AffichageGrille()
        {
            Console.WriteLine(" {0} | {1} | {2} ", grille[0,0], grille[1,0], grille[2,0]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", grille[0, 1], grille[1, 1], grille[2,1]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", grille[0, 2], grille[1, 2], grille[2, 2]);
        }
    }
}
