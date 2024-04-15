
namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esercitazioni.EsercitazioneProprieta();
        }
    }
    public interface IUtente
    {
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione{ get; }
    }
}

    internal class Libro {
        internal string Id { get; set; }
        internal string Title { get; set; }
        internal string Author { get; set; }
        internal Utente Utente { get; set; }
        internal string Descrizione
        {
            get
            {
                return $"{Title} di {Author}";
            }
        }

        internal Libro(string id, string title, string author)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
        }

        internal void Prestito(Utente? utente) {

            //var locale e non d'istana
            if (utente == null) { } 


            if (this.Utente == null)
                this.Utente = utente;
            else
                Console.WriteLine("Libro già in prestito");
        }
        internal void Restituzione()
        {
            Console.WriteLine(
                $"Libro {Title} restituito da {Utente.Denominazione}");
            this.Utente = null;
        }

    }

    //classe dove ogni metodo rappresentera il main di un'esercitazione
    static internal class Esercitazioni
    {
        //static internal void PrimoEsempio()
        //{
        //    Utente Federico = new Utente("000001", "Federico", "Martelloni", 2024);
        //    Utente Pino = new Utente("000002", "Pino", "Abetoni", 2024);
        //    Libro It = new Libro("001", "It", "Stefano Re");

        //    It.Prestito(Federico);
        //    It.Prestito(Pino);
        //    It.Prestito(null);
        //    It.Restituzione();
        //    It.Prestito(Pino);
        //}
        //static internal void EsercitazioneProprieta()
        //{
        //    Utente utente1 = new Utente()
        //    {
        //        Id = "000001",
        //        Name = "Martina",
        //        Surname = "Bruni",
        //        AnnoIscrizione = 2024
        //    };
        //    Utente utente2 = new Utente()
        //    {
        //        Id = "000002",
        //        Name = "Devid",
        //        Surname = "Cimarelli",
        //        AnnoIscrizione = 2023
        //    };

        //    Console.WriteLine($"Utente 1: {utente1.Id} {utente1.Denominazione} {utente1.AnnoIscrizione}");
        //    Console.WriteLine($"Utente 2: {utente2.Id} {utente2.Denominazione} {utente2.AnnoIscrizione}");

        //    Console.WriteLine($"Sto scambiando l'id dei due utenti");
        //    string tmp = utente1.Id;
        //    utente1.Id = utente2.Id;
        //    utente2.Id = tmp;
        //    Console.WriteLine($"Id utente1: {utente1.Id}");
        //    Console.WriteLine($"Id utente2: {utente2.Id}");

        //    Console.WriteLine($"Sto scambiando il nome dei due utenti");
        //    tmp = utente1.Name;
        //    utente1.Name = utente2.Name;
        //    utente2.Name = tmp;
        //    Console.WriteLine($"Nome utente1: {utente1.Name}");
        //    Console.WriteLine($"Nome utente2: {utente2.Name}");

        //    Console.WriteLine($"Sto scambiando il cognome dei due utenti");
        //    tmp = utente1.Surname;
        //    utente1.Surname = utente2.Surname;
        //    utente2.Surname = tmp;
        //    Console.WriteLine($"Cognome utente1: {utente1.Surname}");
        //    Console.WriteLine($"Cognome utente2: {utente2.Surname}");

        //    Console.WriteLine($"Sto scambiando l'anno di iscrizione dei due utenti");
        //    int tmp2 = utente1.AnnoIscrizione;
        //    utente1.AnnoIscrizione = utente2.AnnoIscrizione;
        //    utente2.AnnoIscrizione = tmp2;
        //    Console.WriteLine($"AnnoIscrizione utente1: {utente1.AnnoIscrizione}");
        //    Console.WriteLine($"AnnoIscrizione utente2: {utente2.AnnoIscrizione}");
        //}
    }

}