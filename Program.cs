namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utente Federico = new Utente("000001", "Federico", "Martelloni", 2024);
            Utente Pino = new Utente("000002", "Pino", "Abetoni", 2024);
            Libro It = new Libro("001", "It","Stefano Re");
            
            It.Prestito(Federico);
            It.Prestito(Pino);
            It.Prestito(null);

            It.Restituzione();
            It.Prestito(Pino);

            Console.Write(Pino.Denominazione);
        }
    }
    internal class Utente {
        internal string id {  get; set; }
        internal string name { get; set; }
        internal string surname { get; set; }
        internal int annoIscrizione { get; set; }
        public string Denominazione { get { return $"{this.name} {this.surname}"; } }

        /*Costruttore della classe Utente*/
        internal Utente (string id, string name, string surname, int annoIscrizione)               
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.annoIscrizione = annoIscrizione;
        }
    }

    internal class Libro {
        internal string id {  get; set; }
        internal string title { get; set; }
        internal string author { get; set; }
        internal Utente? utente { get; set; }
        public string Descrizione { get { return $"{title} di {author}"; } }
        
        /*Il costruttore della classe Libro*/
        internal Libro(string id, string title, string author)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.utente = null;
        }

        internal void Prestito(Utente? utente)
        {
            if (utente != null)
            {
                if (this.utente == null)
                {
                    this.utente = utente == null ? null : utente;
                    Console.WriteLine($"{this.Descrizione} > {utente?.Denominazione}");
                }
                else
                {
                    Console.WriteLine("Err. Already on loan");
                }
            }
            else
            {
                Console.WriteLine("Err. Arguments");
            }
        }
        internal void Restituzione()
        {
            if (this.utente == null)
            {
                Console.WriteLine("Err. Not on loan");
            }
            else
            {
                Console.WriteLine($"{this.Descrizione} < {this.utente.Denominazione}");
                this.utente = null;
            }
        }
    }
}
