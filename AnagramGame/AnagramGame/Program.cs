using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramGame
{
    class Program
    {

        

        static void Main(string[] args)
        {
            bool run = true;

            PrintMenu();

            while (run)
            {
                
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.S:
                        ChallengeMode();
                        break;
                    case ConsoleKey.A:
                        PracticeMode();
                        break;
                    case ConsoleKey.C:
                       ClearScreen();
                        PrintMenu();
                        break;
                    case ConsoleKey.Escape:
                        run = false;
                        break;

                }
            }
            Console.ReadKey();
        }

        private static void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine("                         ********************************");
            Console.WriteLine("                         *|----------------------------|*");
            Console.WriteLine("                         *| Benvenuto ad AnagramFunRun |*");
            Console.WriteLine("                         *|----------------------------|*");
            Console.WriteLine("                         ********************************");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                                                                                ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Scegli la modalità di gioco");
            Console.WriteLine("");
            Console.WriteLine("Sfida<S> oppure Allenamento<A>");
            
        }

        private static void ChallengeMode()
        {
            Console.WriteLine("");
            Console.WriteLine("Modalità scelta: Sfida");
            Console.WriteLine("");
            Console.WriteLine("                     - - - - - Regole del gioco - - - - -");
            Console.WriteLine("Quando premerai Invio ti verrà data una parola della quale dovrai un suo anagramma nel minor tempo possibile.");
            Console.WriteLine("                        - - - - - Punteggio - - - - -");
            Console.WriteLine("Risposta entro 3 secondi: 15 punti");
            Console.WriteLine("Risposta entro 5 secondi: 10 punti");
            Console.WriteLine("Risposta entro 6 secondi: 6 punti");
            Console.WriteLine("Risposta entro 7 secondi: 4 punti");
            Console.WriteLine("Risposta entro 8 secondi: 2 punti");
            Console.WriteLine("Risposta entro 9 secondi: 1 punto");
            Console.WriteLine("Risposta oltre 10 secondi: 0 punti");
        }

        private static void PracticeMode()
        {
            Console.WriteLine("");
            Console.WriteLine("Modalità scelta: Allenamento");
            Console.WriteLine("");
        }

        private static void ClearScreen()
        {
            Console.Clear();
        }

    }
}
