namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utente Federico = new Utente ("000001","Federico","Martelloni",2024);
            
            Utente Pino = new Utente ("000002","Pino","Abetoni", 2024 );


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
        string Id { get; set;}
        string Name { get; set; }
        string Surname { get; set; }
        int AnnoIscrizione { get; set; }
        internal string Denominazione {
            get { return $"{Name}{Surname}";}
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
        string Id { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        Utente Utente { get; set; }
    string Descrizione { get { return $"{Title} di {Author}"; }}
    
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

