using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialisation des variables:
            char choixMenu = ' ';
            double premierNombre = 0;
            double deuxiemeNombre = 0;
            double resultat = 0;
            int nombreEntier = 0;
            List<int> listeDesDiviseurs = new List<int>();
            int deuxiemeNombreEntier = 0;
            Random aleatoire = new Random();

            do
            {
                //Choix de l'opération par l'utilisateur:
                TitrageMenu("CALCULATRICE");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("--- Choisir une opération ---");
                Console.ResetColor();
                Console.Write("\n + --- addition\t\t\t^ --- puissance\t\t\t? --- nombre aléatoire" +
                    "\n - --- soustraction\t\tv --- racine carrée" +
                    "\n * --- multiplication\t\t! --- factorielle" +
                    "\n / --- division\t\t\t# --- liste des diviseurs\t0 --- QUITTER" +
                    "\n\n Choix : ");
                choixMenu = char.Parse(Console.ReadLine());

                //REDIRECTION DANS LES DIFFÉRENTS CALCULS
                switch (choixMenu)
                {
                    case '+':
                        Titrage("ADDITION");
                        Addition();
                        Console.Write($"La somme de {premierNombre} et {deuxiemeNombre} vaut ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{resultat}\n"); //<-- résultat mis en valeur en couleur.
                        Console.ResetColor();
                        break;
                    case '-':
                        Titrage("SOUSTRACTION");
                        Soustraction();
                        Console.Write($"La différence de {premierNombre} et {deuxiemeNombre} vaut ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{resultat}\n");//<-- résultat mis en valeur en couleur.
                        Console.ResetColor();
                        break;
                    case '*':
                        Titrage("MULTIPLICATION");
                        Multiplication();
                        Console.Write($"Le produit de {premierNombre} et {deuxiemeNombre} vaut ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{resultat}\n");//<-- résultat mis en valeur en couleur.
                        Console.ResetColor();
                        break;
                    case '/':
                        Titrage("DIVISION");
                        Division();
                        Console.Write($"Le quotient de {premierNombre} par {deuxiemeNombre} vaut ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{resultat}\n");//<-- résultat mis en valeur en couleur.
                        Console.ResetColor();
                        break;
                    case '^':
                        Titrage("PUISSANCE");
                        Puissance();
                        Console.Write($"La puissance de {premierNombre} par {deuxiemeNombre} vaut ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{resultat}\n");//<-- résultat mis en valeur en couleur.
                        Console.ResetColor();
                        break;
                    case 'v':
                        Titrage("RACINE CARRÉE");
                        RacineCarree();
                        Console.Write($"La racine carrée de {premierNombre} vaut ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{resultat}\n");//<-- résultat mis en valeur en couleur.
                        Console.ResetColor();
                        break;
                    case '!':
                        Titrage("FACTORIELLE");
                        Factorielle();
                        Console.Write($"La factorielle de {nombreEntier} vaut ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{resultat}\n");//<-- résultat mis en valeur en couleur.
                        Console.ResetColor();
                        break;
                    case '#':
                        Titrage("LISTE DES DIVISEURS");
                        ChercheDiviseurs();
                        Console.Write($"{nombreEntier} a {listeDesDiviseurs.Count} diviseurs qui sont :");
                        Console.ForegroundColor = ConsoleColor.Cyan;//<-- résultat mis en valeur en couleur.
                        for (int i = 0; i < listeDesDiviseurs.Count; i++)
                        {
                            if (i < listeDesDiviseurs.Count - 2)
                            {
                                Console.Write($" {listeDesDiviseurs[i]},");//<--diviseurs listés entre virgules.
                            }
                            else if (i == listeDesDiviseurs.Count - 2)
                            {
                                Console.Write($" {listeDesDiviseurs[i]} et");//<--avant-dernier diviseur séparé par le derier par "et".
                            }
                            else//<-- if (i == listeDesDiviseurs.Count - 1)
                            {
                                Console.WriteLine($" {listeDesDiviseurs[i]}");//<--dernier diviseur affiché seul
                            };
                        };
                        Console.ResetColor();
                        if (listeDesDiviseurs.Count == 2) //<-- S'il n'a que deux diviseurs, le nombre est premier.
                        {
                            Console.WriteLine($"{nombreEntier} est donc un nombre premier.\n");
                        }
                        else
                        {
                            Console.WriteLine("\n");
                        };
                        break;
                    case '?':
                        Titrage("NOMBRE ALÉATOIRE");
                        NombreAleatoire();
                        Console.Write($"Voici un nombre aléatoirement tiré entre {nombreEntier} et {deuxiemeNombreEntier - 1} : ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{resultat}\n");//<-- résultat mis en valeur en couleur.
                        Console.ResetColor();
                        break;
                    case '0':
                        Environment.Exit(0); //<--Sortie du programme
                        break;
                };
            } while (true);

            //Fonction TITRAGE:
            //Affichage d'un titre encadré en jaune
            void Titrage(string titre)
            {
                Console.Clear();

                titre = $"║ {titre} ║";
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("╔");
                for (int i = 0; i < titre.Length - 2; i++)
                {
                    Console.Write("═");
                };
                Console.WriteLine("╗");
                Console.WriteLine(titre);
                Console.Write("╚");
                for (int i = 0; i < titre.Length - 2; i++)
                {
                    Console.Write("═");
                };
                Console.WriteLine("╝");
                Console.ResetColor();
            };

            //Fonction TITRAGE MENU:
            //Affichage d'un titre rouge (sans Console.Clear)
            void TitrageMenu(string titre)
            {
                titre = $"║ {titre} ║";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("╔");
                for (int i = 0; i < titre.Length - 2; i++)
                {
                    Console.Write("═");
                };
                Console.WriteLine("╗");
                Console.WriteLine(titre);
                Console.Write("╚");
                for (int i = 0; i < titre.Length - 2; i++)
                {
                    Console.Write("═");
                };
                Console.WriteLine("╝");
                Console.ResetColor();
            };


            //Fonction ADDITION:
            void Addition()
            {
                //Attributions des valeurs:
                Console.Write("Entrer un premier terme : ");
                premierNombre = double.Parse(Console.ReadLine());
                Console.Write("Entrer un deuxième terme : ");
                deuxiemeNombre = double.Parse(Console.ReadLine());
                //Calcul de la somme:
                resultat = premierNombre + deuxiemeNombre;
            };

            //Fonction SOUSTRACTION:
            void Soustraction()
            {
                //Attributions des valeurs:
                Console.Write("Entrer un premier terme : ");
                premierNombre = double.Parse(Console.ReadLine());
                Console.Write("Entrer un soustracteur : ");
                deuxiemeNombre = double.Parse(Console.ReadLine());
                //Calcul de la différence:
                resultat = premierNombre - deuxiemeNombre;
            };

            //Fonction MULTIPLICATION:
            void Multiplication()
            {
                //Attributions des valeurs:
                Console.Write("Entrer un premier facteur : ");
                premierNombre = double.Parse(Console.ReadLine());
                Console.Write("Entrer un deuxième facteur : ");
                deuxiemeNombre = double.Parse(Console.ReadLine());
                //Calcul du produit:
                resultat = premierNombre * deuxiemeNombre;
            };

            //Fonction DIVISION:
            void Division()
            {
                //Attributions des valeurs:
                Console.Write("Entrer un dividende : ");
                premierNombre = double.Parse(Console.ReadLine());
                do
                {
                    Console.Write("Entrer un diviseur : ");
                    deuxiemeNombre = double.Parse(Console.ReadLine());
                    if (deuxiemeNombre == 0) //<--Vérification que le diviseur != 0.
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\tLe diviseur ne peut pas valoir 0 !");
                        Console.ResetColor();
                    };
                } while (deuxiemeNombre == 0);
                //Calcul du quotient:
                resultat = premierNombre / deuxiemeNombre;
            };

            //Fonction PUISSANCE:
            void Puissance()
            {
                //Attributions des valeurs:
                Console.Write("Entrer un facteur : ");
                premierNombre = double.Parse(Console.ReadLine());
                Console.Write("Entrer un exposant : ");
                deuxiemeNombre = double.Parse(Console.ReadLine());
                //Calcul du produit:
                resultat = Math.Pow(premierNombre, deuxiemeNombre);
            };

            //Fonction RACINE Carrée:
            void RacineCarree()
            {
                //Attributions des valeurs:
                do
                {
                    Console.Write("Entrer un nombre positif : ");
                    premierNombre = double.Parse(Console.ReadLine());
                    if (premierNombre < 0)//<--Vérification que le nombre est positif.
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\t Le nombre doit être supérieur à 0 !");
                        Console.ResetColor();
                        Console.Write("Entrer un nombre positif: ");
                        premierNombre = double.Parse(Console.ReadLine());
                    };
                } while (premierNombre < 0);
                //Calcul de la racine:
                resultat = Math.Sqrt(premierNombre);
            };

            //Fonction FACTORIELLE:
            void Factorielle()
            {
                //Attributions des valeurs:
                do
                {
                    Console.Write("Entrer un nombre entier positif: ");
                    nombreEntier = int.Parse(Console.ReadLine());
                    if (nombreEntier <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\t Le nombre doit être supérieur à 0 !");
                        Console.ResetColor();
                    };
                } while (nombreEntier <= 0);
                //Calcul de la factorielle:
                resultat = nombreEntier;
                for(double i = nombreEntier - 1; i > 1; i--)
                {
                    resultat *= i;
                };
            };

            //Fonction LISTE DES DIVISEURS:
            void ChercheDiviseurs()
            {
                //Attributions des valeurs:
                do
                {
                    Console.Write("Entrer un nombre entier positif: ");
                    nombreEntier = int.Parse(Console.ReadLine());
                    if (nombreEntier <= 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\t Le nombre doit être supérieur à 1 !");
                        Console.ResetColor();
                    };
                } while (nombreEntier <= 1);
                //Calcul des diviseurs:
                listeDesDiviseurs.Clear();
                for(int i = 1; i <= nombreEntier; i++)
                {
                    if (nombreEntier % i == 0)
                    {
                        listeDesDiviseurs.Add(i);
                    };
                };
            };

            void NombreAleatoire()
            {
                //Attributions des valeurs (bornes):
                Console.Write("Entrer une borne inférieure (incluse) : ");
                nombreEntier = int.Parse(Console.ReadLine());
                do
                {
                    Console.Write("Entrer une borne supérieure (incluse) : ");
                    deuxiemeNombreEntier = int.Parse(Console.ReadLine()) + 1;//<-- +1 pour que la borne soit incluse.
                    if (deuxiemeNombreEntier < nombreEntier)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\t La borne supérieure doit être supérieur à la borne inférieure !");
                        Console.ResetColor();
                    };
                } while (deuxiemeNombreEntier < nombreEntier);
                
                //Tirage du résultat aléatoire:
                resultat = aleatoire.Next(nombreEntier, deuxiemeNombreEntier);
            };
        }
    }
}