using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialisation des variables:
            double premierNombre = 0;
            double deuxiemeNombre = 0;
            double resultat = 0;
            char choixMenu = ' ';

            //Choix de l'opération par l'utilisateur:
            Console.Write("--- Choisir une opération ---" +
                "\n + --- multiplication" +
                "\n - --- soustraction" +
                "\n * --- multiplication" +
                "\n / --- division" +
                "\n ^ --- puissance" +
                "\n v --- racine carrée" +
                "\n ! --- factorielle" +
                "\n 0 --- QUITTER" +
                "\n\n Choix : ");
            choixMenu = char.Parse(Console.ReadLine());

            //REDIRECTION DANS LES DIFFÉRENTS CALCULS
            switch (choixMenu)
            {
                case '+':
                    Addition();
                    Console.WriteLine($"La somme de {premierNombre} et {deuxiemeNombre} vaut {resultat}");
                    break;
                case '-':
                    Soustraction();
                    Console.WriteLine($"La différence de {premierNombre} et {deuxiemeNombre} vaut {resultat}");
                    break;
                case '*':
                    Multiplication();
                    Console.WriteLine($"Le produit de {premierNombre} et {deuxiemeNombre} vaut {resultat}");
                    break;
                case '/':
                    Division();
                    Console.WriteLine($"Le quotient de {premierNombre} par {deuxiemeNombre} vaut {resultat}");
                    break;
                case '^':
                    Puissance();
                    Console.WriteLine($"La puissance de {premierNombre} par {deuxiemeNombre} vaut {resultat}");
                    break;
                case 'v':
                    RacineCarree();
                    Console.WriteLine($"La racine carrée de {premierNombre} vaut {resultat}");
                    break;
                case '!':
                    Factorielle();
                    Console.WriteLine($"La factorielle de {premierNombre} vaut {resultat}");
                    ////NE MARCHE PAS ENCORE!!!!
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
            };

            //ADDITION
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

            //SOUSTRACTION:
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

            //MULTIPLICATION:
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

            //DIVISION:
            void Division()
            {
                //Attributions des valeurs:
                Console.Write("Entrer un dividende : ");
                premierNombre = double.Parse(Console.ReadLine());
                do
                {
                    Console.Write("Entrer un diviseur : ");
                    deuxiemeNombre = double.Parse(Console.ReadLine());
                    if (deuxiemeNombre == 0)
                    {
                        Console.WriteLine("Le diviseur ne peut pas valoir 0.");
                    };
                } while (deuxiemeNombre == 0);
                //Calcul du quotient:
                resultat = premierNombre / deuxiemeNombre;
            };

            //PUISSANCE:
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

            //RACINE:
            void RacineCarree()
            {
                //Attributions des valeurs:
                Console.Write("Entrer un nombre : ");
                premierNombre = double.Parse(Console.ReadLine());
                //Calcul de la racine:
                resultat = Math.Sqrt(premierNombre);
            };

            //FACTORIELLE:
            void Factorielle()
            {
                //Attributions des valeurs:
                Console.Write("Entrer un nombre : ");
                premierNombre = double.Parse(Console.ReadLine());
                //Calcul de la factorielle:
                for(double i = premierNombre; i > 1; i--)
                {
                    resultat *= i;
                };
            };
        }
    }
}