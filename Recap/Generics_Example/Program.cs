using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Person<Cat> catLover1 = new Person<Cat>();
            catLover1.Pets.Add(new Cat() { Nickname = "Bigglesworth" });

            Person<Cat> catLover2 = new Person<Cat>();
            catLover2.Pets.Add(new Cat() { Nickname = "Meowington" });

            Person<Dog> dogLover1 = new Person<Dog>();
            dogLover1.Pets.Add(new Dog() { Nickname = "Reginald" });
        }
    }

    class Animal
    {
        public string Nickname { get; set; }
    }

    class Cat : Animal { }

    class Dog : Animal { }

    class Person<T> where T : Animal
    {
        public string Name { get; set; }
        public List<T> Pets { get; set; }
    }

    class CatLover : Person<Cat> { }

    class DogLover : Person<Dog> { }
}
