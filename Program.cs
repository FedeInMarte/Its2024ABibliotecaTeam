

using System.Runtime.CompilerServices;

namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        static IUtente[]? Utenti;


        static void StampaUtente()
        {
            foreach (IUtente elem in Utenti)
            {
                if(elem != null)
                {
                    Console.WriteLine(elem.Denominazione);

                }
            }
        }

        static void Main(string[] args)
        {
            Utenti = new IUtente[5];

            Utenti[0] = new Persona("1024", "Filippo", "Gammaidoni", 2021);
            Utenti[1] = new Organizzazione("ITS Umbria", "2024", 2024);

            StampaUtente();
        }
    }
    interface IUtente
    {
        string Id { get; set; }
        int AnnoIscrizione { get; set; }
        string Denominazione { get; }
    }
    class Persona : IUtente
    {
        string Nome { get; set; }
        string Cognome { get; set; }
        public string Denominazione { get { return $"{this.Nome} {this.Cognome}"; } }

        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }

        internal Persona(string id, string name, string surname, int annoIscrizione)
        {
            this.Id = id;
            this.Nome = name;
            this.Cognome = surname;
            this.AnnoIscrizione = annoIscrizione;
        }
    }
    class Organizzazione : IUtente
    {
        string RagioneSociale { get; set; }
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione { get { return $"{this.Id} {this.RagioneSociale}"; } }

        public Organizzazione(string ragioneSociale, string id, int annoIscrizione)
        {
            this.RagioneSociale = ragioneSociale;
            this.Id = id;
            this.AnnoIscrizione = annoIscrizione;
        }
    }

    internal class Libro
    {
        internal string id { get; set; }
        internal string title { get; set; }
        internal string author { get; set; }
        internal Persona? utente { get; set; }
        public string Descrizione { get { return $"{title} di {author}"; } }
        public event Action<string> libroDisponibile;

        /*Il costruttore della classe Libro*/
        internal Libro(string id, string title, string author)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.utente = null;
        }

        internal void Prestito(Persona? utente)
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
                libroDisponibile(this.Descrizione);
            }
        }
    }
}