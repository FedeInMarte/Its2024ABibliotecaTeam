
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
                string input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "p":
                        Persona p = new Persona();
                        Console.WriteLine("Inserisci nome");
                        p.Name = Console.ReadLine();
                        Console.WriteLine("Inserisci cognome");
                        p.Surname = Console.ReadLine();
                        Console.WriteLine("Inserisci id");
                        p.Id = Console.ReadLine();
                        Console.WriteLine("Inserisci anno iscrizione");
                        string annoIscr = Console.ReadLine();
                        while(int.TryParse(annoIscr, out _) == false)
                        {
                            Console.WriteLine("Anno iscrizione non valido, riprova");
                            annoIscr = Console.ReadLine();
                        }
                        p.AnnoIscrizione = Convert.ToInt32(annoIscr);
                        utenti.Add(p);
                        break;
                    case "o":
                        Organizzazione o = new Organizzazione();
                        Console.WriteLine("Inserisci Ragione sociale");
                        o.RagioneSociale = Console.ReadLine();
                        Console.WriteLine("Inserisci id");
                        o.Id = Console.ReadLine();
                        Console.WriteLine("Inserisci anno iscrizione");
                        string annoI = Console.ReadLine();
                        while (int.TryParse(annoI, out _) == false)
                        {
                            Console.WriteLine("Anno iscrizione non valido, riprova");
                            annoI = Console.ReadLine();
                        }
                        o.AnnoIscrizione = Convert.ToInt32(annoI);
                        utenti.Add(o);
                        break;
                    case "e":
                        Console.Clear();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Input non valido");
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
        }
        /*static internal void PrimoEsempio()
        {
            Utente Federico = new Utente("000001", "Federico", "Martelloni", 2024);
            Utente Pino = new Utente("000002", "Pino", "Abetoni", 2024);
            Libro It = new Libro("001", "It", "Stefano Re");

            It.Prestito(Federico);
            It.Prestito(Pino);
            It.Prestito(null);
            It.Restituzione();
            It.Prestito(Pino);
        }*/
        /*static internal void EsercitazioneProprieta()
        {
            Utente utente1 = new Utente()
            {
                Id = "000001",
                Name = "Martina",
                Surname = "Bruni",
                AnnoIscrizione = 2024
            };
            Utente utente2 = new Utente()
            {
                Id = "000002",
                Name = "Devid",
                Surname = "Cimarelli",
                AnnoIscrizione = 2023
            };

            Console.WriteLine($"Utente 1: {utente1.Id} {utente1.Denominazione} {utente1.AnnoIscrizione}");
            Console.WriteLine($"Utente 2: {utente2.Id} {utente2.Denominazione} {utente2.AnnoIscrizione}");

            Console.WriteLine($"Sto scambiando l'id dei due utenti");
            string tmp = utente1.Id;
            utente1.Id = utente2.Id;
            utente2.Id = tmp;
            Console.WriteLine($"Id utente1: {utente1.Id}");
            Console.WriteLine($"Id utente2: {utente2.Id}");

            Console.WriteLine($"Sto scambiando il nome dei due utenti");
            tmp = utente1.Name;
            utente1.Name = utente2.Name;
            utente2.Name = tmp;
            Console.WriteLine($"Nome utente1: {utente1.Name}");
            Console.WriteLine($"Nome utente2: {utente2.Name}");

            Console.WriteLine($"Sto scambiando il cognome dei due utenti");
            tmp = utente1.Surname;
            utente1.Surname = utente2.Surname;
            utente2.Surname = tmp;
            Console.WriteLine($"Cognome utente1: {utente1.Surname}");
            Console.WriteLine($"Cognome utente2: {utente2.Surname}");

            Console.WriteLine($"Sto scambiando l'anno di iscrizione dei due utenti");
            int tmp2 = utente1.AnnoIscrizione;
            utente1.AnnoIscrizione = utente2.AnnoIscrizione;
            utente2.AnnoIscrizione = tmp2;
            Console.WriteLine($"AnnoIscrizione utente1: {utente1.AnnoIscrizione}");
            Console.WriteLine($"AnnoIscrizione utente2: {utente2.AnnoIscrizione}");
        }*/
    }
    public interface IUtente
    {
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione{ get; }
    }
    internal class Persona : IUtente
    {
        internal string Name { get; set; }
        internal string Surname { get; set; }
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione
        {
            get
            {
                return $"{Id} {Name} {Surname}";
            }
        }
    }
    internal class Organizzazione : IUtente
    {
        internal string RagioneSociale { get; set; }
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione
        {
            get
            {
                return $"{Id} {RagioneSociale}";
            }
        }
    }
    //internal class Libro
    //{
    //    internal string Id { get; set; }
    //    internal string Title { get; set; }
    //    internal string Author { get; set; }
    //    internal Utente Utente { get; set; }
    //    internal string Descrizione
    //    {
    //        get
    //        {
    //            return $"{Title} di {Author}";
    //        }
    //    }

    //    internal Libro(string id, string title, string author)
    //    {
    //        this.Id = id;
    //        this.Title = title;
    //        this.Author = author;
    //    }

    //    internal void Prestito(Utente? utente)
    //    {

    //        //var locale e non d'istana
    //        if (utente == null) { }


    //        if (this.Utente == null)
    //            this.Utente = utente;
    //        else
    //            Console.WriteLine("Libro già in prestito");
    //    }
    //    internal void Restituzione()
    //    {
    //        Console.WriteLine(
    //            $"Libro {Title} restituito da {Utente.Denominazione}");
    //        this.Utente = null;
    //    }

    //}

    //classe dove ogni metodo rappresentera il main di un'esercitazione

}

    