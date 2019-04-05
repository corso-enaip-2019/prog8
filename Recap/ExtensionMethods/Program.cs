using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>
            {
                "ciao",
                "123",
                "a",
                "pippo",
            };

            IEnumerable<string> result = list.Filter(x => x.Length < 3);
            foreach (string s in result)
                Console.WriteLine(s);


            Console.Read();
        }
    }

    static class Extensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> input, Filter<T> condition)
        {
            List<T> output = new List<T>();

            foreach (T item in input)
                if (condition(item))
                    output.Add(item);

            return output;
        }
    }

    delegate bool Filter<T>(T item);
}
