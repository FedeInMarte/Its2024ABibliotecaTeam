namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utente f = new Utente("001", "Francesco", "Renghi", 2024);

            Utente p = new Utente("002", "Pino", "Abetone", 2023);

            Libro It = new Libro("001", "It", "Stefano Re");

            It.Prestito(f);
            It.Prestito(p);
            It.Prestito(null);

            It.Restituzione();
            It.Prestito(p);
            
        }
    }

    internal class Utente
    {
        private object get;

        internal string Id { get; set; }
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal int AnnoIscrizione { get; set; }
        

        internal Utente(string id, string name, string surname, int annoIscrizione)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.AnnoIscrizione = annoIscrizione;
        }


        internal string Descrizione{
            get{ return $"{this.Name} {this.Surname}"; }
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
                return $"{this.Title} di {this.Author}";
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

            //var locale e non d'istanza
            if (utente == null) { }


            if (this.Utente == null)
                this.Utente = utente;
            else
                Console.WriteLine("Libro già in prestito");
        }
        internal void Restituzione()
        {
            Console.WriteLine($"Libro {this.Title} restituito da {this.Utente.Descrizione}");
            this.Utente = null;
        }

    }

}