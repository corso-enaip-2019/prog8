
using System;
using System.Collections.Generic;

namespace EsercizioNumPrimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quanti numeri primi vuoi vedere?");
            string primeQuantityString = Console.ReadLine();
            bool hasConverted = int.TryParse(primeQuantityString, out int primeQuantity);
            int i = 0;
            List<int> myPrimeNumbersList = new List<int>();

            while (myPrimeNumbersList.Count < primeQuantity)
            {
                if (isPrime(i))
                {
                    myPrimeNumbersList.Add(i);
                }
                i++;
            }
            
            for (int j = 0; j < myPrimeNumbersList.Count; j++)
            {
                if (j % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"{j + 1}: {myPrimeNumbersList[j]}");
            }
            Console.ReadLine();
        }

        static bool isPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i <= (int)Math.Floor(Math.Sqrt(n)); i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        
    }
}
