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

            
        }
    }

    internal class Utente {
        internal string Id { get; set; }
        internal string Name {  get; set; }
        internal string Surname {  get; set; }
        internal int AnnoIscrizione {  get; set; }

        internal string Denominazione
        {
            get
            {
                return $"{this.Name} {this.Surname}";
                //this.name + " " + this.surname;
            }

        }


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

     
    }

    internal class Libro {
        internal string Id {  get; set; }
        internal string Title {  get; set; }
        internal string Author {  get; set; }
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

}