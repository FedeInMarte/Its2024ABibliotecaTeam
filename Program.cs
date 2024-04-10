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

            Console.WriteLine("Hello, World!");
        }
    }

    internal class Utente {
        private string id;
        private string name;
        private string surname;
        private int annoIscrizione;

        internal Utente (string id, 
            string name, 
            string surname, 
            int annoIscrizione)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.annoIscrizione = annoIscrizione;
        }

        internal string Denominazione()
        {
            return $"{this.name} {this.surname}"; 
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

        internal string Descrizione()
        {
            return $"{title} di {author}";
        }
        internal void Prestito(Utente? utente) {

            //var locale e non d'istana
            if (utente == null) { } 


            if (this.utente == null)
                this.utente = utente;
            else
                Console.WriteLine("Libro già in prestito");
        }
        internal void Restituzione()
        {
            Console.WriteLine(
                $"Libro {title} restituito da {utente.Denominazione()}");
            this.utente = null;
        }

    }

}