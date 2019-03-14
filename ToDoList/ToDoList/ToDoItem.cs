using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDoItem
    {
        public int Id { get; set; }
        public string Descrizione { get; set; }
        public bool Completato { get; set; }
        public int UtenteId { get; set; }
    }
    
}
