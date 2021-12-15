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

        public static bool TestDimensionSaisie(int num, int[,] grille)
        {
            if (num > 0 && num <=grille.GetLength(0) && num > 0 && num <=grille.GetLength(1)) {
                return true;
            }

           

            return false;
        }


        public static int SaisirLigneValide(int numLigne, int[,] grille)
        {

            do
            {
                Console.Write("Veuillez saisir le numéro d'une ligne (1,2,3) : ");
                numLigne = TestValiditeDuTypeDeLaSaisie();
                Console.WriteLine();
            } while (TestDimensionSaisie(numLigne, grille) == false);
                
            return numLigne;
        }

        public static int SaisirColonneValide(int numColonne, int[,] grille)
        {

            do
            {
                Console.Write("Veuillez saisir le numéro d'une colonne (1,2,3) : ");
                numColonne = TestValiditeDuTypeDeLaSaisie();
                Console.WriteLine();
            } while (TestDimensionSaisie(numColonne, grille) == false);

            return numColonne;
        }
        


        static void Main(string[] args)
        {
           

            
          

            bool etatProgramme = true;


            while (etatProgramme == true)
            {
                bool etatPartie = true;
                int joueur = 2;

                Console.WriteLine("Jouer au morpion : 1");
                Console.WriteLine("Jouer à puissance4 : 2");
                Console.WriteLine();
                Console.WriteLine("N'importe quelle touche pour quitter !");

                int num;
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.Write("Choisi ton jeu (1,2) :");

                }

                if (num == 1)
                {
                    Console.WriteLine("Bienvenue sur le jeu Tic Tac Toe !");
                    Console.WriteLine();

                    GrilleMorpion grilles = new GrilleMorpion();

                    int[,] grille = grilles.grille;
                    int numLigne = grilles.numLigne;
                    int numColonne = grilles.numColonne;

                    while (etatPartie == true)
                    {

                        joueur = alterneJoueur(joueur);
                        Console.WriteLine("C'est au tour du joueur " + joueur + "!");
                        Console.WriteLine();
                        grilles.AffichageGrille();
                        Console.WriteLine();

                        grilles.numLigne = SaisirLigneValide(numLigne, grille) - 1;
                        grilles.numColonne = SaisirColonneValide(numColonne, grille) - 1;

                        if (grilles.CaseVide(grilles.numLigne, grilles.numColonne))
                        {
                            grilles.deposeJeton(grilles.numLigne, grilles.numColonne, joueur);
                            Console.Clear();

                        }
                        else
                        {
                            joueur = alterneJoueur(joueur);
                            Console.Clear();
                            Console.WriteLine("La case est déjà prise !");
                        }


                        if (grilles.VictoireJoueur(joueur))
                        {
                            etatPartie = false;

                        }

                        if (grilles.GrilleComplete())
                        {
                            etatPartie = false;
                        }
                    }

                    if (grilles.VictoireJoueur(joueur) == true)
                    {
                        grilles.AffichageGrille();
                        Console.WriteLine();
                        Console.WriteLine("Victoire du joueur " + joueur);
                    }
                    else if (grilles.GrilleComplete() == true && grilles.VictoireJoueur(joueur) == false)
                    {
                        grilles.AffichageGrille();
                        Console.WriteLine();
                        Console.WriteLine("Personne a gagné !");
                    }


                } else if(num == 2)
                {
                    Console.WriteLine("Bienvenue sur le jeu Puissance4 !");
                    Console.WriteLine();

                    GrillePuissance4 grilles = new GrillePuissance4();

                    int[,] grille = grilles.grille;
                    int numLigne = grilles.numLigne;
                    int numColonne = grilles.numColonne;

                    while (etatPartie == true)
                    {

                        joueur = alterneJoueur(joueur);
                        Console.WriteLine("C'est au tour du joueur " + joueur + "!");
                        Console.WriteLine();
                        grilles.AffichageGrille();
                        Console.WriteLine();

                        grilles.numLigne = SaisirLigneValide(numLigne, grille) - 1;
                        grilles.numColonne = SaisirColonneValide(numColonne, grille) - 1
                        break;

                    }
                }
            
                else
                {
                    Console.Clear();
                    Console.WriteLine("Au revoir !");
                    etatProgramme = false;
                }

                Console.WriteLine();
            }
            
        }



          

       
    }
}
