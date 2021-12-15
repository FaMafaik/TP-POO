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
            if (grille[0, 0] == numJoueur && grille[1, 1] == numJoueur && grille[2, 2] == numJoueur)
            {
                return true;
            }
            else if (grille[0, 2] == numJoueur && grille[1, 1] == numJoueur && grille[2, 0] == numJoueur)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VictoireJoueur(int numJoueur)
        {
            if (ligneComplete(numJoueur) || colonneComplete(numJoueur) || diagonaleComplete(numJoueur))
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
