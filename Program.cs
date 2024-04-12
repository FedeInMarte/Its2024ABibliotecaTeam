namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utente Federico = new Utente
            {
                Id = "000001",
                Name = "Federico",
                Surname = "Martelloni",
                AnnoIscrizione = 2024
            };

            Utente Pino = new Utente
            {
                Id = "000002",
                Name = "Pino",
                Surname = "Abetoni",
                AnnoIscrizione = 2024
            };
            Libro It = new Libro("001", "It","Stefano Re");
            It.Prestito(Federico);
            It.Prestito(Pino);
            //It.Prestito(null);

            It.Restituzione();
            It.Prestito(Pino);

            //Console.WriteLine("Hello, World!");
        }
    }

    internal class Utente {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int AnnoIscrizione { get; set; }
        // private int varInutile;

        internal Utente ()
        {
            //this.id = id;
            //this.name = name;
            //this.surname = surname;
            //this.annoIscrizione = annoIscrizione;
        }

        internal string Denominazione
        {
            get
            {
                return $"{this.Name} {this.Surname}";
            }
            
            //this.name + " " + this.surname;
        }
    }

    internal class Libro {
        private string id;
        private string title;
        private string author;
        private Utente utente;
    
        internal Libro(string id, string title, string author)
        {
            this.id = id;
            this.title = title;
            this.author = author;
        }

        internal string Descrizione
        {
            get
            {
                return $"{title} di {author}";
            }
            
        }
        internal void Prestito(Utente? utente) {

            //var locale e non d'istanza
            if (utente == null) { }


            if (this.utente == null)
            {
                this.utente = utente;
                Console.WriteLine($"Libro prestato a {utente.Denominazione}");
            }
            else
                Console.WriteLine("Libro già in prestito");
        }
        internal void Restituzione()
        {
            Console.WriteLine(
                $"Libro {title} restituito da {utente.Denominazione}");
            this.utente = null;
        }
        //prova commit
    }

}