
using Its2024ABibliotecaTeam.Entita;

namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EsercitazioneInterface();
        }
        static internal void StampaUtente(List<IUtente> arr)
        {
            foreach (IUtente u in arr)
            {
                Console.WriteLine(u.Denominazione);
            }
        }
        static internal void EsercitazioneInterface()
        {
            List<IUtente> utenti = new List<IUtente>();
            bool exit = false;
            do
            {
                Console.Clear();
                exit = false;
                Console.WriteLine("Inserisci \'p\' per aggiungere persone");
                Console.WriteLine("Inserisci \'o\' per aggiungere organizzazione");
                Console.WriteLine("Inserisci \'e\' per uscire");
                string? input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "p":
                        utenti.Add(new Persona());
                        break;
                    case "o":
                        utenti.Add(new Organizzazione());
                        break;
                    case "e":
                        Console.Clear();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Input non valido");
                        Console.WriteLine("Premi qualsiasi tasto per continuare...");
                        Console.ReadLine();
                        break;
                }
            } while (!exit);
            if(utenti.Count() == 0)
            {
                Console.WriteLine("Lista utenti vuota");
            }
            else
            {
                Console.WriteLine("Stampo gli utenti");
                StampaUtente(utenti);
            }
            utenti.Clear();
            Console.WriteLine("PROGRAMMA TERMINATO");
        }
    }
}

    