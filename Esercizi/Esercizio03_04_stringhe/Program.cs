using System;
using System.Collections.Generic;
using System.Linq;

namespace Esercizio03_04_stringhe
{
    class Program
    {
        

        static void Main(string[] args)
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
            //print the list of input strings
            Console.WriteLine();
            Console.WriteLine("Your list of words is: ");
            foreach (string s in myStrings)
                Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine("-------------");

            //print the list of short strings
            IEnumerable<string> shortStrings = Filter(myStrings, new ShortStringFilter());
            Console.WriteLine();
            Console.WriteLine("These are the strings with less than 3 letters:");
            foreach (string s in shortStrings)
                Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine("-------------");

            //print the list of strings convertible to numbers
            IEnumerable<string> stringsToNumber = Filter(myStrings, new ConvertibleToNumberFilter());
            Console.WriteLine();
            Console.WriteLine("These are the strings that are convertible to numbers:");
            foreach (string s in stringsToNumber)
                Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine("-------------");

            IEnumerable<string> stringsBeginningInA = Filter(myStrings, new StartsWithFilter('a'));
            Console.WriteLine();
            Console.WriteLine("These are the strings that begin in A:");
            foreach (string s in stringsToNumber)
                Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine("-------------");


            Console.ReadLine();
        }

        private static IEnumerable<T> Filter<T>(IEnumerable<T> input, IFilter<T> condition)
        {
            List<T> output = new List<T>();

            foreach (T s in input)
                if (condition.Filter(s))
                    output.Add(s);

            return output;
        }
        
        interface IFilter<T>
        {
            bool Filter(T item);
        }

        class ShortStringFilter : IFilter<string>
        {
            public bool Filter(string s)
            {
                return s.Length < 3;
            }
        }

        class ConvertibleToNumberFilter : IFilter<string>
        {
            public bool Filter(string s)
            {
                return int.TryParse(s, out int _);
            }
        }

        class StartsWithFilter : IFilter<string>
        {
            private char _initialLower;
            private char _initialUpper;

            public StartsWithFilter(char initial)
            {
                _initialLower = char.ToLower(initial);
                _initialUpper = char.ToUpper(initial);
            }

            public bool Filter(string s)
            {
                return s.StartsWith(_initialLower) || s.StartsWith(_initialUpper);
            }
        }

        private static IEnumerable<TOutput> Project<TInput, TOutput>(IEnumerable<TInput> input, IProject<TInput, TOutput> projection)
        {
            List<TOutput> output = new List<TOutput>();

            foreach (TInput item in input)
            {
                TOutput projected = projection.Project(item);
                output.Add(projected);
            }
            return output;
        }

        interface IProject<Tinput, TOutput>
        {
            TOutput Project(TInput item);
        }

        class LengthOfStringProjector : IProject<string, int>
        {
            public int Project(string item)
            {
                return item.Length;
            }
        }

        class InvertedStringProjector : IProject<string, string>
        {
            public string Project(string item)
            {
                string result = "";

            }
        }
    }
}
