using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
    class Liste
    {
        public void List()
        {
            List<string> stringhe; //crea la lista stringhe
            stringhe = new List<string>(); //la inizializza
            stringhe.Add("uno"); //aggiunge il primo elemento alla lista stringhe
            //new List<string>(); //crea una lista senza nominarla
            string primoItem = stringhe[0]; //primoItem = "uno"
            stringhe.Remove("uno"); //rimuove l'item con valore "uno"
            stringhe.RemoveAt(stringhe.IndexOf("uno")); //trova l'index dell'item "uno" e lo rimuove

            List<int> interi = new List<int>(); //crea lista e la inizializza
            interi.Add(25); //aggiunge l'item '25'
            interi.Remove(25); //remove l'item '25'
        }

        public void Queue()
        {
            Queue<string> codaStringhe = new Queue<string>();
            codaStringhe.Enqueue("uno"); //inserisce l'elemento "uno"
            string nextElement = codaStringhe.Peek(); //restituisce l'elemento senza rimuoverlo
            nextElement = codaStringhe.Dequeue(); //restituisce l'elemento della queue rimuovendolo
        }

        public void Stack()
        {
            Stack<int> stackInteri = new Stack<int>();
            stackInteri.Push(1); //inserisce l'elemento '1'
            int first = stackInteri.Peek(); //restituisce l'elemento senza rimuoverlo
            first = stackInteri.Pop(); //restituisce l'elemento della queue rimuovendolo
        }
       
    }
}
