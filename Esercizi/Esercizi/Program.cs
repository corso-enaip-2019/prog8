using System;
using System.Collections.Generic;

namespace Esercizi
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("1.1");
            Console.WriteLine("----------");


            int magicNumber = 42;
            Console.WriteLine($"As we all know, the answer to all the quesions is {magicNumber} (if you don't know that, search on the Internet!).");

            //1.2
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("1.2");
            Console.WriteLine("----------");

            Console.Write("Let's see if yours is a magic number. Type a number and I'll tell you if it's divisible by 42. ");

            bool inputNumberBool = int.TryParse(Console.ReadLine(), out int inputNumber);

            if (inputNumber % 42 == 0) Console.WriteLine("It is! You found a magic number.");
            else Console.WriteLine("It's not! You found a regular boring number.");

            //2
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("2");
            Console.WriteLine("----------");

            int myNumber = 17;
            int myNumbersDouble = myNumber * 2;
            int myNumbersTriple = myNumber * 3;

            Console.WriteLine($"I chose the number {myNumber}. Its double is {myNumbersDouble} and its triple is {myNumbersTriple}.");

            //3.1
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("3.1");
            Console.WriteLine("----------");

            Console.WriteLine("These numbers are divisible by 3 AND 5:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.Write($"{i}, ");
            }
            Console.WriteLine("");
            Console.WriteLine("These numbers are divisible by 3 OR 5:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) Console.Write($"{i}, ");
            }
            Console.WriteLine("");
            Console.WriteLine("These are the first 100 numbers that are divisible by 3 and 5");
            List<int> HundredNumbers = new List<int>();
            while(true)
            {

            }

            Console.ReadLine();
        }
    }
}
