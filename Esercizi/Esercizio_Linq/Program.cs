using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) numero fi inquilini di tutti gli appartamenti di classe energetica A
            // 2) media del numero di inquilini di tutti gli appartamenti
            // 3) di ongi città, nome di città e elenco di vie degli appartamenti
            // 4) di ogni città, nome di città e media dei mq
            // 5) di ogni città, nome di città e media dei mq, tutti ordinati per nome di città e dentro le città ordinati per via
            // 6) elenco dei nomi di città che hanno appartamenti non in classe a, b, c.
        }

    }

    class Flat
    {
        public int SquareMetres { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int Flatmates { get; set; }
        public EnergyClassType EnergyClass { get; set; }
    }

    enum EnergyClassType
    {
        A, B, C, D, E, F, G
    }
}
