using System.Xml.Linq;

namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        private static IUtente[] utenti;
        public static void stampaUtente()
        {
            for (int i = 0; i < utenti.Length; i++)
            {
                Console.WriteLine(utenti[i].Denominazione);
            }
        }
        static void Main(string[] args)
        {
            /*Utente Federico = new Utente("000001", "Federico", "Martelloni", 2024);
            Utente Pino = new Utente("000002", "Pino", "Abetoni", 2024);

            Libro It = new Libro("001", "It","Stefano Re");
            It.Prestito(Federico);
            It.Prestito(Pino);
            It.Prestito(null);
            It.Restituzione();
            It.Prestito(Pino);*/
            
            Persona persona = new Persona("Luca", "Rossi", "1", 2020);
            Organizzazione organizzazione = new Organizzazione("Marco", "2", 2020);
            utenti = new IUtente[] { persona, organizzazione};
            stampaUtente();
        }
    }

    internal class Utente {
        internal string Id { get; set; }
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal int AnnoIscrizione { get; set; }
        //string Denominazione { get; set; } = $"{Name} {Surname}";

        internal string Denominazione {
            get { return $"{Name} di {Surname}"; }
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

        /*internal string Denominazione()
        {
            return $"{this.Name} {this.Surname}";
            //this.name + " " + this.surname;
        }*/
    }

    internal class Libro {
        internal string Id { get; set; }
        internal string Title { get; set; }
        internal string Author { get; set; }
        internal Utente Utente { get; set; }

        internal Libro(string id, string title, string author)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
        }

        internal string Descrizione
        {
            get { return $"{Title} di {Author}"; }
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

    public interface IUtente
    {
        string Id { get; set; }
        int AnnoIscrizione { get; set; }
        string Denominazione { get; }
    }

    class Persona : IUtente
    {

        internal string Nome { get; set; }
        internal string Cognome { get; set; }
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione
        {
            get { return $"{this.Id} {this.Nome} {this.Cognome}"; }
        }
        public Persona(string nome, string cognome, string id, int annoIscrizione)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Id = id;
            this.AnnoIscrizione = annoIscrizione;
        }
    }

    class Organizzazione : IUtente
    {
        internal string RagioneSociale { get; set; }
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione
        {
            get { return $"{this.Id} {this.RagioneSociale}"; }
        }
        public Organizzazione(string ragioneSociale, string id, int annoIscrizione)
        {
            this.RagioneSociale = ragioneSociale;
            this.Id = id;
            this.AnnoIscrizione = annoIscrizione;
        }
    }
}