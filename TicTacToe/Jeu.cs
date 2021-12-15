using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTicTacToe{

    public class Jeu 
    {
        public static int alterneJoueur(int joueur)
        {
            if (joueur.Equals(1))
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }


        static int TestValiditeDuTypeDeLaSaisie()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Veuillez saisir un entier : ");
            }
            return num;
        }

        static bool TestDimensionSaisie(int num)
        {
            if (num > 0 && num <=3 && num > 0 && num <=3) {
                return true;
            }

            return false;
        }

        public static int SaisirLigneValide(GrilleMorpion morpion)
        {

            do
            {
                Console.Write("Veuillez saisir le numéro d'une ligne (1,2,3) : ");
                morpion.numLigne = TestValiditeDuTypeDeLaSaisie();
                Console.WriteLine();
            } while (TestDimensionSaisie(morpion.numLigne) == false);
                
            return morpion.numLigne;
        }

        public static int SaisirColonneValide(GrilleMorpion morpion)
        {

            do
            {
                Console.Write("Veuillez saisir le numéro d'une colonne (1,2,3) : ");
                morpion.numColonne = TestValiditeDuTypeDeLaSaisie();
                Console.WriteLine();
            } while (TestDimensionSaisie(morpion.numColonne) == false);

            return morpion.numColonne;
        }
        


        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue sur le jeu Tic Tac Toe !");
            Console.WriteLine();

            GrilleMorpion grille = new GrilleMorpion();
            int joueur = 2;

            bool etatPartie = true;
         
            while(etatPartie == true)
            {

                joueur = alterneJoueur(joueur);
                Console.WriteLine("C'est au tour du joueur " + joueur + "!");
                Console.WriteLine();
                grille.AffichageGrille();
                Console.WriteLine();

                grille.numLigne = SaisirLigneValide(grille)-1;
                grille.numColonne = SaisirColonneValide(grille)-1;

                if (grille.CaseVide(grille.numLigne, grille.numColonne))
                {
                    grille.deposeJeton(grille.numLigne, grille.numColonne, joueur);
                    Console.Clear();

                } else
                {
                    joueur = alterneJoueur(joueur);
                    Console.Clear();
                    Console.WriteLine("La case est déjà prise !");
                }


                if (grille.VictoireJoueur(joueur))
                {
                    etatPartie = false;

                }

                if(grille.GrilleComplete())
                {
                    etatPartie = false;
                }
            }

            if(grille.VictoireJoueur(joueur) == true)
            {
                grille.AffichageGrille();
                Console.WriteLine();
                Console.WriteLine("Victoire du joueur " + joueur);
            } else if(grille.GrilleComplete() == true && grille.VictoireJoueur(joueur) == false)
            {
                grille.AffichageGrille();
                Console.WriteLine();
                Console.WriteLine("Personne a gagné !");
            }
           

        }

       
    }
}
