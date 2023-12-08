using System;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean choix = false;
            int choisir;

            Console.ForegroundColor = System.ConsoleColor.White;
            Random rnd = new Random();

            Boolean victoire = false;
            Console.WriteLine("taille de votre mastermind? ");
            int taille = Convert.ToInt32(Console.ReadLine());
            string[] tab = new string[taille];
            string[] answer = new string[taille];
            string[] verif = new string[taille];
            int b,compteur=0,total=0;
            string a,z;
            
            Console.WriteLine("La partie peut commencer! ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            info();
            generate();
            while (victoire==false)
            {
                //remplir le tableau verif de x
                for (int i = 0; i < verif.Length; i++)
                {
                    verif[i] = "x";
                }
                Console.WriteLine(" ");
                Console.Write("Votre proposition :   ");
                a = Console.ReadLine();

                a=a.Replace(" ", string.Empty);
                //rempli le tableau de notre réponse avec des substrings
                for(int i = 0; i < a.Length; i++)
                {
                    String substring = a.Substring(i, 1);
                    tab[i] = substring;
                }
                total = 0;
                affichagereponse();
                //compte le nombre de tour 
                compteur++;
                //permet de vérifier si les cases de la solution et de la réponse sont égales
                for (int i = 0; i < tab.Length; i++)
                {
                    if (tab[i] == answer[i]) 
                    {
                        total++;
                        verif[i] = "v";
                    }
                }
                if (total == verif.Length)
                {
                    victoire = true;
                }
                affichageverif();
                info();
            }
            Console.WriteLine("Bravo vous avez trouvé en " + compteur + " tours");
            void menu()
            {
                Console.WriteLine("Voulez-vous jouer en Joueur contre Joueur (1) ou contre l'ordinateur (2): ");
                choisir = Convert.ToInt32(Console.ReadLine());
                if (choisir == 1)
                {
                    choix = true;
                }
                else if (choisir == 2)
                {
                    choix = false;
                }
            }
            //remplie le tableau en fonction de la taille choisie
            void generate()
            {
                for (int i = 0; i < answer.Length; i++)
                {
                    b = rnd.Next(5);
                    if (b == 0)
                    {
                        answer[i] = "0";
                    }
                    else if (b == 1)
                    {
                        answer[i] = "1";
                    }
                    else if (b == 2)
                    {
                        answer[i] = "2";
                    }
                    else if (b == 3)
                    {
                        answer[i] = "3";
                    }
                    else  
                    {
                        answer[i] = "4";
                    }
                }
            }
            //affiche la grille avec les couleurs correspondantes
            void affichagereponse()
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    if (tab[i] == "0")
                    {
                        Console.BackgroundColor = System.ConsoleColor.DarkRed;
                        Console.ForegroundColor = System.ConsoleColor.DarkRed;
                    }
                    else if (tab[i] == "1")
                    {
                        Console.BackgroundColor = System.ConsoleColor.DarkBlue;
                        Console.ForegroundColor = System.ConsoleColor.DarkBlue;
                    }
                    else if (tab[i] == "2")
                    {
                        Console.BackgroundColor = System.ConsoleColor.DarkGreen;
                        Console.ForegroundColor = System.ConsoleColor.DarkGreen;
                    }
                    else if (tab[i] == "3")
                    {
                        Console.BackgroundColor = System.ConsoleColor.DarkYellow;
                        Console.ForegroundColor = System.ConsoleColor.DarkYellow;
                    }
                    else if (tab[i] == "4")
                    {
                        Console.BackgroundColor = System.ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
                    }
                    Console.Write(tab[i]);
                    Console.BackgroundColor = System.ConsoleColor.Black;
                    Console.ForegroundColor = System.ConsoleColor.White;
                    Console.Write(" ");
                }
                Console.BackgroundColor = System.ConsoleColor.Black;
                Console.ForegroundColor = System.ConsoleColor.White;
            }

            //permet de vérifier les 2 tableaux
            void affichageverif()
            {
                Console.WriteLine(" ");
                for (int i = 0; i < verif.Length; i++)
                {
                    if (verif[i] == "x")
                    {
                        Console.ForegroundColor = System.ConsoleColor.DarkRed;
                    }

                    else if (verif[i] == "v")
                    {
                        Console.ForegroundColor = System.ConsoleColor.DarkGreen;
                    }
                    Console.Write(verif[i]);
                    Console.BackgroundColor = System.ConsoleColor.Black;
                    Console.ForegroundColor = System.ConsoleColor.White;
                    Console.Write(" ");
                }
                Console.BackgroundColor = System.ConsoleColor.Black;
                Console.ForegroundColor = System.ConsoleColor.White;
            }
            void info()
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write(" code couleur: 0 = ");
                Console.BackgroundColor = System.ConsoleColor.DarkRed;
                Console.ForegroundColor = System.ConsoleColor.DarkRed;
                Console.Write("aaa");
                Console.BackgroundColor = System.ConsoleColor.Black;
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.Write(" | 1 = ");
                Console.BackgroundColor = System.ConsoleColor.DarkBlue;
                Console.ForegroundColor = System.ConsoleColor.DarkBlue;
                Console.Write("aaa");
                Console.BackgroundColor = System.ConsoleColor.Black;
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.Write(" | 2 = ");
                Console.BackgroundColor = System.ConsoleColor.DarkGreen;
                Console.ForegroundColor = System.ConsoleColor.DarkGreen;
                Console.Write("aaa");
                Console.BackgroundColor = System.ConsoleColor.Black;
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.Write(" | 3 = ");
                Console.BackgroundColor = System.ConsoleColor.DarkYellow;
                Console.ForegroundColor = System.ConsoleColor.DarkYellow;
                Console.Write("aaa");
                Console.BackgroundColor = System.ConsoleColor.Black;
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.Write(" | 4 = ");
                Console.BackgroundColor = System.ConsoleColor.DarkMagenta;
                Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
                Console.Write("aaa");
                Console.BackgroundColor = System.ConsoleColor.Black;
                Console.ForegroundColor = System.ConsoleColor.White;
                Console.WriteLine("");
            }
        }
    }
}
