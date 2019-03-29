using System;

namespace Recap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = ReadFromConsole();

            PrintAllModes(p);

            Console.Read();

        }

        private static void ReadFromConsole()
        {
            Person p = new Person();

            Console.Write("Inserire il nome della Persona: ");
            p.Name = Console.ReadLine();

            Console.Write("Inserire il cognome della Persona: ");
            p.Surname = Console.ReadLine();

            Console.Write("Inserire il genere della Persona: ");
            p.Gender = Console.ReadLine();

            Console.Write("Inserire lo stipendio della Persona: ");
            string salaryString = Console.ReadLine();
            p.Salary = decimal.Parse(salaryString);

            Console.Write("Inserire l'indirizzo della Persona: ");
            p.Address = Console.ReadLine();

            
        }

        static void PrintAllModes(Person p)
        {

            PrintInLine(p);
            Console.WriteLine();
            PrintLarge(p);

        }

        static void PrintInLine(Person p)
        {
            Console.Write($"nome: {p.Name}; cognome: {p.Surname}; genere: {p.Gender}; salario: {p.Salary} ; indirizzo: {p.Address}");

        }

        static void PrintLarge(Person p)
        {
            Console.WriteLine($"nome: {p.Name}");
            Console.WriteLine($"cognome: {p.Surname}");
            Console.WriteLine($"genere: {p.Gender}");
            Console.WriteLine($"salario: {p.Salary} ");
            Console.WriteLine($"indirizzo: {p.Address} ");
        }

        class Person
        {
            // una classe ha membri:
            // - campi (fields)
            // - metodi (methods)
            // - proprietà (properties)
            // - eventi (events)
            public string Name;
            public string Surname;
            public string Gender;
            public decimal Salary;
            public string Address;
        }
        //static void Main(string[] args)
        //{

        //    Console.Write("Inserire il nome della Persona: ");
        //    string name = Console.ReadLine();

        //    Console.Write("Inserire il cognome della Persona: ");
        //    string surname = Console.ReadLine();

        //    Console.Write("Inserire il genere della Persona: ");
        //    string gender = Console.ReadLine();

        //    Console.Write("Inserire lo stipendio della Persona: ");
        //    string salaryString = Console.ReadLine();
        //    decimal salary = decimal.Parse(salaryString);

        //    Console.Write("Inserire l'indirizzo della Persona: ");
        //    string address = Console.ReadLine();

        //    PrintAllModes(name, surname, gender, salary, address);

        //    Console.Read();
        //}

        //static void PrintAllModes(string name, string surname, string gender, decimal salary, string address)
        //{

        //    PrintInLine(name, surname, gender, salary, address);
        //    Console.WriteLine();
        //    PrintLarge(name, surname, gender, salary, address);

        //}

        //static void PrintInLine(string name, string surname, string gender, decimal salary, string address)
        //{
        //    Console.Write($"nome: {name}; cognome: {surname}; genere: {gender}; salario: {salary} ");

        //}

        //static void PrintLarge(string name, string surname, string gender, decimal salary, string address)
        //{
        //    Console.WriteLine($"nome: {name}");
        //    Console.WriteLine($"cognome: {surname}");
        //    Console.WriteLine($"genere: {gender}");
        //    Console.WriteLine($"salario: {salary} ");
        //}

    }
}
