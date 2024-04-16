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

            IUtente p = new Persona("001","Giacomo", "Mariotti",2024)

            ;

            IUtente o = new Organizzazione
            {
                Id = "002",
                RagioneSociale = "Viva"
            };

            IUtente[] utenti;
            
            utenti= new IUtente[]{ p,o};

            StampaUtente(utenti);

            Emitter e= new Emitter();
            Listener l1= new Listener();
            Listener l2= new Listener();

            e.NewMessage += l1.MessageHandler;
            e.NewMessage += l2.MessageHandler;

            
            Persona persona= new Persona("004", "Andrea","Ricci",2024);

            Libro It = new Libro("001", "It", "Stefano Re");

            bool funziona = false;

            while (funziona == false) {
            Console.WriteLine("Inserisci l'azione che vuoi fare:");
            Console.WriteLine("1.Prendi in presito il libro" + " "+
                              "2.Restituisci il libro"+ " " +
                              "3. niente");
            int sceltaU = Convert.ToInt32(Console.ReadLine());

            switch(sceltaU)
            {
                case 1:
                    It.Prestito(persona);
                    Console.WriteLine("Libro preso in prestito");
                    break;
                case 2:
                    It.Restituzione();
                    e.Message = "Libro Restituito";
                    break;
                case 3:
                        funziona= true;
                    break;
            } }

            //
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

        public Persona (string nome, string cognome, string id, int annoIscrizione)
        {
            Nome = nome;
            Cognome = cognome;
            Id = id;
            AnnoIscrizione = annoIscrizione;
        }

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

    } 

public class Emitter
{
    private string message;

    public string Message
        {
            get { return message; }
            set
            {
                message = value;
                OnNewMessage(message);
            }
        }

    public event Action <string> NewMessage;

    public void OnNewMessage(string msg)
    {
        if(NewMessage != null)
        {
            NewMessage(msg);
        }
    }

}

public class Listener
{
    public void MessageHandler(string Message)
    {
        Console.WriteLine($"Ricevuto il messaggio {Message}");
        Console.WriteLine("Ora puoi prenotare il libro");
    }
}

}
//Libro It = new Libro("001", "It", "Stefano Re");
//It.Prestito(Federico);
//It.Prestito(Pino);
//It.Prestito(null);

//It.Restituzione();
//It.Prestito(Pino);


