using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartScreen
{
    class Program
    {
        static int firstOrNot = 0;
        static string playerName;
        static string secretWord = "UMBRELLA";
        static string maskedWord;
        static string tryCharacter;

        static void Main(string[] args)
        {
            Menu();

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Here is the word we are lookig for, now guessing characters it's up to you");

            int lettersInWord = secretWord.Length;

            Console.WriteLine();
            Console.Write("\t");
            for (int i = 0; i < lettersInWord; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("What character would you like to try? ");
            tryCharacter = Console.ReadLine();

            RightOrNot();
        }

        static void Menu()
            {
            Console.Clear();
                Console.WriteLine("\n                                                     ");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\t                                                                       ");
                Console.WriteLine("\t               ▓▓▓▓▒    ▓▒      ▓▓▓▓▓▒   ▓▓▓▓▒                         ");
                Console.WriteLine("\t              ▓▒   ▓▒   ▓▒      ▓▒      ▓▒   ▓▒                        ");
                Console.WriteLine("\t              ▓▒   ▓▒   ▓▒      ▓▒      ▓▒   ▓▒                        ");
                Console.WriteLine("\t              ▓▒   ▓▒   ▓▒      ▓▓▓▒    ▓▒   ▓▒                        ");
                Console.WriteLine("\t              ▓▒▓▓▒▓▒   ▓▒      ▓▒      ▓▒▓▓▒▓▒                        ");
                Console.WriteLine("\t              ▓▒   ▓▒   ▓▒      ▓▒      ▓▒   ▓▒                        ");
                Console.WriteLine("\t              ▓▒   ▓▒   ▓▓▓▓▓▒  ▓▒      ▓▒   ▓▒                        ");
                Console.WriteLine("\t                                                                       ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\t                 Välkommen till Hangman!                               ");
                Console.WriteLine("\t                                                                       ");
                Console.WriteLine("\t                 1: Instruktioner                                      ");
                Console.WriteLine("\t                 2: Starta spelet                                      ");
                Console.WriteLine("\t                 3: Avsluta                                            ");
                Console.WriteLine("\t                                                                       ");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("\t              Val: ");
                
            while (firstOrNot < 1)
                {
                    Console.Beep(850, 210);
                   /* Console.Beep(1250, 210);
                    Console.Beep(1650, 210);*/
                    firstOrNot++;
                }


                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                    {
                    case 1:
                        Instructions();
                        break;
                    case 2:
                        StartGame();
                        break;
                    case 3:
                        EndScreen();
                        break;
                    default:
                        Console.WriteLine("Pleace choose 1, 2 or 3");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Menu();
                    break;
                    }


            Console.ResetColor();

            }
        static void Instructions()
        {
            Console.Clear();
            Console.WriteLine("Instruktioner för att spela!");
            Console.ReadLine();
            Menu();

        }
        static void StartGame()
        {
            Console.Clear();
            Console.Write("What´s your name: ");
            playerName = Console.ReadLine();

            Console.WriteLine("Welcome " + playerName + " to Hangman!");
            
            Console.ReadLine();
            //Menu();
        }

        static void RightOrNot()
        {
            Console.WriteLine("Nu är vi i RightOrNot " + tryCharacter);
            Console.ReadLine();
        }
        static void EndScreen()
        {
            Console.Clear();
            Console.WriteLine("Tack så mycket för att du spelade Hangman");
            Console.ReadLine();
        }
        }
}
