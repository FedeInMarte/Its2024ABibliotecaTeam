using Its2024ABibliotecaTeam;
using System.Net.NetworkInformation;

namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        IUtente[] utenti;
            
            static void StampaUtente(IUtente[] utenti)
            {
                foreach(IUtente u in utenti)
                {
                    Console.WriteLine(u.Denominazione);
                }
            }
        static void Main(string[] args)
        {

            IUtente p = new Persona
            {
                Id = "001",
                Nome = "Giacomo",
                Cognome = "Mariotti",
                AnnoIscrizione = 2024

            };

            IUtente o = new Organizzazione
            {
                Id = "002",
                RagioneSociale = "Viva"
            };

            IUtente[] utenti;
            
            utenti= new IUtente[]{ p,o};

            StampaUtente(utenti);

            //Libro It = new Libro("001", "It", "Stefano Re");
            //It.Prestito(Federico);
            //It.Prestito(Pino);
            //It.Prestito(null);

            //It.Restituzione();
            //It.Prestito(Pino);

        }
    }

    public interface IUtente
    {
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione { get; }

    }

    class Persona : IUtente {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione
        {
            get { return $"{this.Id} {this.Nome} {this.Cognome}"; }
        }

    }

    class Organizzazione : IUtente
    {
        public string RagioneSociale { get; set; }
        public string Id { get; set; }

        public int AnnoIscrizione { get; set; }
        public string Denominazione
        {
            get { return $"{this.Id} {this.RagioneSociale}"; }
        }

    }
    internal class Libro {
        string Id { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        Persona Utente { get; set; }
        string Descrizione { get { return $"{this.Title} di {this.Author}"; } }

        internal Libro(string id, string title, string author)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
        }


        internal void Prestito(Persona? Utente) {

            //var locale e non d'istana
            if (Utente == null) { }


            if (this.Utente == null)
                this.Utente = Utente;
            else
                Console.WriteLine("Libro già in prestito");
        }
        internal void Restituzione()
        {
            Console.WriteLine(
                $"Libro {this.Title} restituito da {Utente.Denominazione}");
            this.Utente = null;
        }

    } }

public class Emitter
{
    private string message;

    public string Message {  
        get { return message; } 
        set {  message = value; 
        OnNewMessage(message);}

    public event Action <string> NewMessage;

    public void OnNewMessage(string msg)
    {
        if(NewMessage != null)
        {
            NewMessage(msg);
        }
    }

}

//Libro It = new Libro("001", "It", "Stefano Re");
//It.Prestito(Federico);
//It.Prestito(Pino);
//It.Prestito(null);

//It.Restituzione();
//It.Prestito(Pino);


