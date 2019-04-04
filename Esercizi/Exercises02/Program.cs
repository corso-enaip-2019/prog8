using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Smartphone> smartphones = CreateSmartphonesMock();
            ChooseColourFilter filter = new ChooseColourFilter(Color.Red);
            Console.WriteLine("These are the Smartphones in red:");
            Console.WriteLine();
            List<Smartphone> byColour = Filter(smartphones, filter).ToList();
            foreach (Smartphone s in byColour)
            {
                Console.WriteLine(s);
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        private static IEnumerable<T> Filter<T>(IEnumerable<T> input, IFilter<T> condition)
        {
            List<T> output = new List<T>();

            foreach (T item in input)
                if (condition.Filter(item))
                    output.Add(item);

            return output;
        }

        static List<Smartphone> CreateSmartphonesMock()
        {
            return new List<Smartphone>
            {
                new Smartphone
                {
                    Model = "OnePlus",
                    Version = "6T",
                    Cost = 699.99,
                    Colour = Color.Black,
                },
                new Smartphone
                {
                    Model = "iPhone",
                    Version = "X",
                    Cost = 1699.99,
                    Colour = Color.Red,
                },
                new Smartphone
                {
                    Model = "Xiaomi",
                    Version = "mi 9",
                    Cost = 399.99,
                    Colour = Color.Black,
                },
                new Smartphone
                {
                    Model = "OnePlus",
                    Version = "2",
                    Cost = 299.99,
                    Colour = Color.Blue,
                },
                new Smartphone
                {
                    Model = "Samsung",
                    Version = "S10",
                    Cost = 799.99,
                    Colour = Color.Blue,
                },
            };
        }
    }

    class Smartphone
    {
        public string Model { get; set; }
        public string Version { get; set; }
        public double Cost { get; set; }
        public Color Colour { get; set; }

        public override string ToString()
        {
            return $" - Model: {Model}, Version: {Version}, Cost: {Cost}";
        }
    }

    interface IFilter<T>
    {
        bool Filter(T item);
    }

    class ChooseColourFilter : IFilter<Smartphone>
    {
        Color colour;

        public ChooseColourFilter(Color search)
        {
            colour = search;
        }

        public bool Filter(Smartphone s)
        {
            return s.Colour == colour;

        }
    }

    //class ChooseMaxPriceFilter : IFilter<Smartphone>
    //{
        

    //    public bool ChooseMaxPriceFilter(Smartphone item)
    //    {
            
    //    }
    //}
}
