namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        public static IUtente[] utenti;
        static void stampaUtenti(IUtente [] ar)
        {
            foreach (IUtente utenti in ar)
            {
                Console.WriteLine(utenti.denominazione);
            }
        }
        static void Main(string[] args)
        {
            //Utente Federico = new Utente("000001", "Federico", "Martelloni", 2024);
            //Utente Pino = new Utente("000002", "Pino", "Abetoni", 2024);


            //Libro It = new Libro("001", "It", "Stefano Re");
            //It.Prestito(Federico);
            //It.Prestito(Pino);
            //It.Prestito(null);

            //It.Restituzione();
            //It.Prestito(Pino);
            IUtente Alessio = new Persone {id = "1 ", annoIscrizione = 2022, nome = "Alessio ", cognome = "Fioriti"};
            IUtente org = new Organizzazione { id = "01 ", annoIscrizione = 2022, ragioneSociale = " Azienda" };
            utenti = new IUtente[] { Alessio, org};
            stampaUtenti(utenti);
        }
    }

    internal class Utente
    {
        internal string Id { get; set; }
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal int AnnoIscrizione { get; set; }
        internal string Denominazione
        {
            get
            {
                return $"{Name} {Surname}";
                //this.name + " " + this.surname;
            }
        }
        internal Utente(string id,
            string name,
            string surname,
            int annoIscrizione)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.AnnoIscrizione = annoIscrizione;
        }
    }

    internal class Libro
    {
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
        internal void Prestito(Utente? utente)
        {

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
    internal interface IUtente
    {
        public string id { get; set; }
        public int annoIscrizione { get; set; }
        public string denominazione { get; }
    }
    class Persone : IUtente
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public string id { get; set; }
        public int annoIscrizione { get; set; }
        public string denominazione
        {
            get { return id + nome + cognome; }
        }
    }
    class Organizzazione : IUtente
    {
        public string id { get; set; }
        public int annoIscrizione { get; set; }
        public string ragioneSociale { get; set; }
        public string denominazione
        {
            get { return id + ragioneSociale; }
        }
    }
}
