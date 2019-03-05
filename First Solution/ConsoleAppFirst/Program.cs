using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numbers
            //int i;  // 0
            //short s;
            //uint ui;
            //long l;
            //float f;
            //double dd;
            //decimal d;
            ////strings
            //string str;  // null
            //char ch;
            ////boolean
            //bool bo;  // false

            //byte bt;

            ////////////////////////

            //str = "ciao";
            //str = str + " Mario";
            //str = string.Concat(str, " Mario");
            //Console.WriteLine(".Write non va a capo, .WriteLine si");
            //Console.ReadLine();

            ////////////////////////

            //Console.WriteLine("Primo lato");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Secondo lato");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Terzo lato");
            //c = Convert.ToInt32(Console.ReadLine());

            //int a = AskAndCheckNumber("Primo lato");
            //int b = AskAndCheckNumber("Secondo lato");
            //int c = AskAndCheckNumber("Terzo lato");

            string[] richiestaNum = new string[3];

            for (int i = 0; i < richiestaNum.Length; i++)
            {
                AskAndCheckNumber("Inserisci lato " + (i + 1));
            }

            int a = Convert.ToInt32(richiestaNum[0]);
            int b = Convert.ToInt32(richiestaNum[1]);
            int c = Convert.ToInt32(richiestaNum[2]);


            bool sumOk = a < b + c && b < a + c && c < a + b && a < Math.Abs(b - c);
            bool diffOk = a > Math.Abs(b -c) && b > Math.Abs(a - c) && c > Math.Abs(a - b) ;
            if (sumOk && diffOk)
            {
                Console.WriteLine("E' un triangolo");
            }
            else
            {
                Console.WriteLine("Non è un triangolo");
                
                int longestSide = Math.Max(Math.Max(a, b), c);
                int indexOfLongestSide = Array.IndexOf(richiestaNum, longestSide);
            }
        }

        
        /// <summary>
        /// mostra all'utente il messaggio e prova a convertire l'input in un numero
        /// </summary>
        /// <param name="message">messaggio mostrato all'utente</param>
        /// <returns>l'intero convertito dalla stringa inserita dall'utente</returns>
        static int AskAndCheckNumber(string message)
        {
            int convertedValue;
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool conversionOk = int.TryParse(input, out convertedValue);
            if (!conversionOk)
                Console.WriteLine("l'input non è valido");

            return convertedValue;
        }

    }
}


