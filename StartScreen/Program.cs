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

        static void Main(string[] args)
        {
            WelcomeMenu();
            //Testar en liten uppdatering

            
        }

        static void WelcomeMenu()
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
                    Console.Beep(1250, 210);
                    Console.Beep(1650, 210);
                    firstOrNot++;
                  //  break;
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
                        WelcomeMenu();
                    break;
                    }


            Console.ResetColor();

            }
        static void Instructions()
        {
            Console.Clear();
            Console.WriteLine("Instruktioner för att spela!");
            Console.ReadLine();
            WelcomeMenu();

        }
        static void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Oj va spelet spelar");
            Console.ReadLine();
            WelcomeMenu();
        }
        static void EndScreen()
        {
            Console.Clear();
            Console.WriteLine("Tack så mycket för att du spelade Hangman");
            Console.ReadLine();
        }
        }
}
