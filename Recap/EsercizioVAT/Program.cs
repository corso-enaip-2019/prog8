using System;
using System.Collections.Generic;

namespace EsercizioVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NormalVat> partiteIvaNormal = new List<NormalVat>
            {
                new NormalVat
                {
                    VatNum = "12345678",
                    Bills = new List<decimal>(),
                    Expenses = new List<decimal>(),
                }
            };
            List<SimpleVat> partiteIvaSimple = new List<SimpleVat>();
            

            NormalVat normalVat_selected = null;
            SimpleVat simpleVat_selected = null;

            partiteIvaNormal.Add(new NormalVat() { VatNum = "12345678" , Bills = new List<decimal>(), Expenses = new List<decimal>()});
            partiteIvaNormal.Add(new NormalVat() { VatNum = "29673434" , Bills = new List<decimal>(), Expenses = new List<decimal>()});
            partiteIvaNormal.Add(new NormalVat() { VatNum = "45374237" , Bills = new List<decimal>(), Expenses = new List<decimal>()});
            partiteIvaNormal.Add(new NormalVat() { VatNum = "18678665" , Bills = new List<decimal>(), Expenses = new List<decimal>()});
            partiteIvaNormal.Add(new NormalVat() { VatNum = "45784567" , Bills = new List<decimal>(), Expenses = new List<decimal>()});
            partiteIvaNormal.Add(new NormalVat() { VatNum = "66786678" , Bills = new List<decimal>(), Expenses = new List<decimal>()});
            partiteIvaSimple.Add(new SimpleVat() { VatNum = "34586246" , Bills = new List<decimal>()});
            partiteIvaSimple.Add(new SimpleVat() { VatNum = "35682486" , Bills = new List<decimal>()});
            partiteIvaSimple.Add(new SimpleVat() { VatNum = "13452356" , Bills = new List<decimal>()});
            partiteIvaSimple.Add(new SimpleVat() { VatNum = "46773423" , Bills = new List<decimal>()});
            partiteIvaSimple.Add(new SimpleVat() { VatNum = "44563410" , Bills = new List<decimal>()});
            partiteIvaSimple.Add(new SimpleVat() { VatNum = "67349359" , Bills = new List<decimal>()});

            Console.WriteLine("");
            Console.WriteLine("                    Benvenuto nel tuo gestore di partite IVA");
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("");
            
            while (true)
            {
                Console.WriteLine("Scrivi il numero dell'operazione da svolgere e premi invio:");
                Console.WriteLine("1. Aggiungi Bill a P.IVA.");
                Console.WriteLine("2. Aggiungi Expense a P.IVA");
                Console.WriteLine("3. Calcola guadagno netto e tasse totali di una P.IVA");
                Console.WriteLine("4. Elenca tutte le P.IVA");

                int operationChosen;
                while(true)
                {
                    bool operationChosenBool = int.TryParse(Console.ReadLine(), out operationChosen);
                    if (operationChosen == 1 || operationChosen == 2 || operationChosen == 3 || operationChosen == 4) break;
                    Console.Write("L'opzione scelta non è valida, reinserire:");
                }

                switch(operationChosen)
                {
                    case 1:
                        {
                            Console.Write("Inserire il numero di partita IVA su cui eseguire l'operazione: ");
                            string vatNumberInput = Console.ReadLine();

                            while (normalVat_selected == null && simpleVat_selected == null)
                            {
                                for (int i = 0; i < partiteIvaNormal.Count; i++)
                                {
                                    if (vatNumberInput == partiteIvaNormal[i].VatNum)
                                    {
                                        Console.WriteLine($"Inserire la quota da aggiungere al numero di P.IVA:  { partiteIvaNormal[i].VatNum }");
                                        bool billBool = int.TryParse(Console.ReadLine(), out int billPartial);

                                        normalVat_selected = partiteIvaNormal[i];
                                        break;
                                    }

                                }
                                for (int i = 0; i < partiteIvaSimple.Count; i++)
                                {
                                    if (vatNumberInput == partiteIvaSimple[i].VatNum)
                                    {
                                        Console.WriteLine($"Il numero di P.IVA num  { partiteIvaSimple[i].VatNum }");
                                        simpleVat_selected = partiteIvaSimple[i];
                                        break;
                                    }
                                }
                                if (normalVat_selected == null && simpleVat_selected == null)
                                {
                                    Console.WriteLine("Il numero inserito non è corretto. Riprova.");
                                    break;
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Inserire il numero di partita IVA su cui eseguire l'operazione: ");
                            bool vatNumberBool = int.TryParse(Console.ReadLine(), out int vatNumber);
                            for (int i = 0; i < partiteIvaNormal.Count; i++)
                            {

                            }
                            break;
                        }
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        {
                            throw new InvalidOperationException();
                        }
                }
            }
            Console.Read();
        }
    }
}
