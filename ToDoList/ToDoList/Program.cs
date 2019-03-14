using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoList t = new ToDoList();
            t.AggiungiToDo("porta fuori il cane", 0);
            t.AggiungiToDo("mangia pizza", 1);
            t.AggiungiToDo("gioca pc", 8);

            t.ViewList();
        }

        
    }
}
