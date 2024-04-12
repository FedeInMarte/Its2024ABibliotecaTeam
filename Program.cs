using System.Net.NetworkInformation;

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
        internal string Id { get; set; }
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal int AnnoIscrizione { get; set; }

        internal Utente() { }

        internal Utente (string id, 
            string name, 
            string surname, 
            int annoIscrizione)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.AnnoIscrizione = annoIscrizione;
        }

        internal string Denominazione
        {
            get
            {
                //this.name + " " + this.surname;
                return $"{this.Name} {this.Surname}";
            }
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
                $"Libro {title} restituito da {utente.Denominazione}");
            this.utente = null;
        }

    }

}