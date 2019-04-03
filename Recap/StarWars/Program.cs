using System;
using System.Collections.Generic;
using System.Linq;

namespace StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot r2d2 = new Robot("R2D2");
            Mum leia = new Mum("Leia");
            Dad hanSolo = new Dad("Han Solo");

            leia.MakeBaby(hanSolo, "Ben Solo");
            leia.Child.AddComforter(r2d2);
            leia.Child.StartCrying();
            leia.Child.StartCrying();
            leia.Child.StartCrying();
            leia.Child.StartCrying();
            leia.Child.StartCrying();

            Console.Read();
        }
    }

    abstract class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("the name cannot be empty or blank");
                name = value;
            }
        }
        private string name;
    }

    class Baby : Person
    {
        public Baby(string name)
            : base(name)
        {
            _comforters = new List<IComforter>();
        }

        public void StartCrying()
        {
            Console.WriteLine($"{Name} has started crying obsessively");

            if (_comforters.Count > 0)
                foreach (IComforter p in _comforters.ToList())
                    p.ComfortChild(this);
            else
                Console.WriteLine($"{Name} becomes Kylo Ren and turns to the dark side");
        }

        public void AddComforter(IComforter p)
        {
            _comforters.Add(p);
        }

        public void RemoveComforter(IComforter p)
        {
            _comforters.Remove(p);
        }

        private List<IComforter> _comforters;
    }

    abstract class Parent : Person, IComforter
    {
        public Parent(string name)
            : base(name)
        { }

        public Baby Child { get; set; }
        public abstract void ComfortChild(Baby baby);
    }

    class Mum : Parent
    {
        public Mum(string name)
            : base(name)
        {
            Patience = 3;
        }

        public override void ComfortChild(Baby baby)
        {
            if (Patience > 0)
            {
                Console.WriteLine($"{Name} prende in braccio {baby.Name} e lo culla");
                Patience--;
            }
            else
            {
                Console.WriteLine($"{Name} gives Ben to Luke and runs away");
                baby.RemoveComforter(this);
            }
        }

        public void MakeBaby(Dad dad, string name)
        {
            Baby baby = new Baby(name);
            Child = baby;
            dad.Child = baby;
            baby.AddComforter(dad);
            baby.AddComforter(this);
            Console.WriteLine($"{Name} has had a baby with {dad.Name}, his name is {baby.Name}");
        }

        public int Patience { get; private set; }
    }

    class Dad : Parent
    {
        public Dad(string name)
            : base(name)
        { }

        public override void ComfortChild(Baby baby)
        {
            Console.WriteLine($"{Name} runs off");
            baby.RemoveComforter(this);
        }
    }

    interface IComforter
    {
        void ComfortChild(Baby baby);
    }

    class Robot : IComforter
    {
        public Robot(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void ComfortChild(Baby baby)
        {
            Console.WriteLine($"{Name} generates a calming frequency to lull {baby.Name} to sleep");
        }
    }
}
