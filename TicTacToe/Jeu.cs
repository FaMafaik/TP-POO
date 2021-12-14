﻿using System;
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

       
        public static int SaisirLigneValide( int numLigne)
        {
          
                Console.Write("Veuillez saisir le numéro d'une ligne : ");
                numLigne = TestValiditeDuTypeDeLaSaisie();
             
                Console.WriteLine();
               

            return numLigne;
        }

        public static int SaisirColonneValide(int numColonne)
        {

            Console.Write("Veuillez saisir le numéro d'une colonne : ");
            numColonne = TestValiditeDuTypeDeLaSaisie();

            Console.WriteLine();


            return numColonne;
        }
        


        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue sur le jeu Tic Tac Toe !");
            Console.WriteLine();

            GrilleMorpion grille = new GrilleMorpion();
            int joueur = 2;
            int numLigne = 0;
            int numColonne = 0;

            bool etatPartie = true;
         
            while(etatPartie == true)
            {

                joueur = alterneJoueur(joueur);
                Console.WriteLine("C'est au tour du joueur " + joueur + "!");
                Console.WriteLine();
                grille.AffichageGrille();
                Console.WriteLine();

          

                numLigne = SaisirLigneValide(numLigne)-1;
                numColonne = SaisirColonneValide(numColonne)-1;
                grille.deposeJeton(numLigne, numColonne, joueur);
                Console.Clear();

                if (grille.VictoireJoueur(joueur) == true)
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
                Console.WriteLine("Personne à gagner " + joueur);
            }
           

        }

       
    }
}
