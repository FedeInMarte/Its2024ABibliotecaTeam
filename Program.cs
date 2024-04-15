using System.Text.Json.Serialization;
using static Its2024ABibliotecaTeam.Libro;

namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        private static IUtente[] utenti;
        public static void StampaUtente()
        {
            for(int i = 0; i < utenti.Length; i++)
            {
                    Console.WriteLine(utenti[i].Denominazione);
                
            }
        }

        static void Main(string[] args)
        {

            //Utente Federico = new Utente("000001", "Federico", "Martelloni", 2024);
            //Utente Pino = new Utente("000002", "Pino", "Abetoni", 2024);

            //Libro It = new Libro("001", "It","Stefano Re");
            //It.Prestito(Federico);
            //It.Prestito(Pino);
            //It.Prestito(null);

            //It.Restituzione();
            //It.Prestito(Pino);

            //Console.WriteLine("Hello, World!");
            Persona Marco = new Persona("245",2018,"Marco","Ferri");
            Organizzazione organizzazione = new Organizzazione("31273",2021,"ITSUmbria");
            utenti = new IUtente[] { Marco, organizzazione };

            StampaUtente();
            

        }
    }

    internal class Utente {
        internal string Id { get; set; }
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal int AnnoIscrizione { get; set; }
        //string Denominazione { get; } = $"dkdadsd";
        internal string Denominazione
        {
            get { return $"{Name} {Surname}"; }
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
        internal string Id { get; set; }
        internal string Title { get; set; }
        internal string Author { get; set; }
        internal Utente Utente { get; set; }
        internal string Descrizione
        {
            get { return $"{Title} di {Author}"; }
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
        internal interface IUtente
        {
            string Id { get; set; }
            int AnnoIscrizione { get; set; }
            string Denominazione { get;}
        }


        internal class Persona : IUtente
        {
           public string Id { get; set; }
           public int AnnoIscrizione { get; set; }
           internal string Nome { get; set; }
           internal string Cognome { get; set; }
           internal Persona(string Id,int AnnoIscrizione,string Nome,string Cognome) { 
            this.AnnoIscrizione = AnnoIscrizione;
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Id = Id;
            }
            public string Denominazione
            {
                get
                {
                    return $"{Nome} {Cognome}";
                }
            }
        }
        internal class Organizzazione : IUtente
        {
            public string Id { get; set; }
            public int AnnoIscrizione { get; set; }
            internal string RagioneSociale { get; set; }
            internal Organizzazione(string id, int annoIscrizione, string ragioneSociale)
            {
                Id = id;
                AnnoIscrizione = annoIscrizione;
                RagioneSociale = ragioneSociale;
            }
            public string Denominazione
            {
                get
                {
                    return $"{Id} {RagioneSociale}";
                }
            }
        }
    }


}