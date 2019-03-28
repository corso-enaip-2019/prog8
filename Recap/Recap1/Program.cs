using System;

namespace Recap1
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                Console.Write("Insert a string: ");
                                
                string input = Console.ReadLine();

                bool isPalindrome = IsPalindrome(input);
                if (isPalindrome)
                    Console.WriteLine("La stringa è palindroma");
                else
                    Console.WriteLine("La stringa non è palindroma");
            }


            

            Console.Read();

        }

        private static bool IsPalindrome(string input)
        {
            // for con due variabili
            //for (int i = 0, j = input.Length - 1; i <= j; i++, j--)
            //{
            //    if (input[i] != input[j]) return false;
            //}


            // for con una variabile
            for (int i = 0; i < input.Length / 2; i++)
                if (input[i] != input[input.Length - i - 1])
                    return false;
            return true;
        }

        private static bool IsPalindromeRecursive(string input)
        {
            if (input.Length == 0 || input.Length == 1)
                return true;

            if (input[0] != input[input.Length - 1])
                return false;

            string newInput = input.Substring(1, input.Length - 2);

            return IsPalindromeRecursive(newInput);


        }
    }
}
