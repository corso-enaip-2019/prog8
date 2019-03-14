using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDoList
    {
        List<ToDoItem> _toDoList;

        public ToDoList()
        {
            _toDoList = new List<ToDoItem>();
        }

        public void AggiungiToDo(string descrizione, int utenteId)
        {
            ToDoItem item = new ToDoItem()
            {
                Id = _toDoList.Count + 1,
                Descrizione = descrizione,
                //Completato = completato, //falso di default
                UtenteId = utenteId
            };
            _toDoList.Add(item);
        }

        public void EditToDo(int id, string descrizione)
        {
            _toDoList[id + 1].Descrizione = descrizione;
        }

        public void CompleteToDo(int id)
        {
            _toDoList[id + 1].Completato = true;
        }

        public void RemoveToDo(int id)
        {
            _toDoList.RemoveAt(id + 1);
        }

        public string ToDoDetail(int id)
        {
            ToDoItem t = _toDoList[id - 1];
            return $"#{t.Id}. ToDo di {t.UtenteId} \n {t.Completato}: {t.Descrizione}";
        }

        public void ViewList()
        {
            foreach(ToDoItem t in _toDoList)
            {
                Console.WriteLine(ToDoDetail(t.Id));
            }
        }

        public List<string> ListToDosByUserId(int utenteId)
        {
            List<string> toDoStrings = new List<string>();

            foreach (ToDoItem t in _toDoList)
            {
                if (t.UtenteId == utenteId)
                {
                    string toDoString = $"#{t.Id} {t.Descrizione}: {t.Completato}";
                    toDoStrings.Add(toDoString);
                }
            }

            return toDoStrings;
        }
        
    }
}
