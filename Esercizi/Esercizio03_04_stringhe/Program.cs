using System;
using System.Collections.Generic;
using System.Linq;

namespace Esercizio03_04_stringhe
{
    class Program
    {
        List<string> myStrings = new List<string>()
            {
                "ambarabaciccicoccò",
                "123456",
                "55",
                "albero",
                "parolalunghissima",
                "oi",
                "tre",
                "bu"
            };

        static void Main(string[] args)
        {

            Console.WriteLine("Your list of words is: ");
            Console.WriteLine();
            
            Console.ReadLine();
        }

        public void Reverse()
        {
            List<string> myReversedStrings = new List<string>();

            for (int i = 0; i < myStrings.Count; i++)
            {
                string reversedWord = "";
                for (int j = myStrings.Count - 1; j == 0; j--)
                {
                    reversedWord += myStrings[i][j];
                }
                myReversedStrings.Add(reversedWord);
            }
            Console.WriteLine(myReversedStrings);
        }

        public void ListItemsLength()
        {
            List<int> myItemsLength = new List<int>();
            for (int i = 0; i < myStrings.Count; i++)
            {
                myItemsLength.Add(myStrings[i].Length);
            }
            Console.WriteLine(myItemsLength);
        }

        public void ShortItems()
        {
            List<string> myShortItems = new List<string>();
            for (int i = 0; i < myStrings.Count; i++)
            {
                if (myStrings[i].Length < 3)
                {
                    myShortItems.Add(myStrings[i]);
                }
            }
        }

        public void ItemsBeginningInA()
        {
            List<string> myItemsInA = new List<string>();
            for (int i = 0; i < myStrings.Count; i++)
            {

            }
        }

        public void ItemsToInt()
        {
            List<string> myItemsToInt = new List<string>();
            for (int i = 0; i < myStrings.Count; i++)
            {
                if(int.TryParse(myStrings[i]))
            }
        }
    }
}
