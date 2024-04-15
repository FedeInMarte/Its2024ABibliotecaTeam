using static System.Net.Mime.MediaTypeNames;

namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        //static List<IUtente> utenti = new List<IUtente>();
        static IUtente[]? utenti;

        static void StampaUtenti()
        {

            foreach (var elemento in utenti)
            {
                Console.WriteLine(elemento.Denominazione);
            }
        }
        static void Main(string[] args)
        {

            //Utente Federico = new Utente("000001", "Federico", "Martelloni", 2024);
            //Utente Pino = new Utente("000002", "Pino", "Abetoni", 2024);

            //Utente utente1 = new Utente()
            //{
            //    Id = "00003",
            //    Name = "Francesco",
            //    Surname = "Fileni",
            //    AnnoIscrizione = 2024
            //};

            //Libro It = new Libro("001", "It","Stefano Re");
            //It.Prestito(Federico);
            //It.Prestito(Pino);
            //It.Prestito(null);

            //It.Restituzione();
            //It.Prestito(Pino);

            IUtente utente = new Persona
            {
                Id = "001",
                AnnoIscrizione = 2024,
                Nome = "Gino",
                Cognome = "Mario"
            };



            IUtente organizzazione = new Organizzazione
            {
                Id = "002",
                AnnoIscrizione = 2021,
                RagioneSociale = "Boooh"
            };

            utenti = new IUtente[] { utente, organizzazione };

            StampaUtenti();

            

        }
    }



    interface IUtente {
        string Id { get; set; }
        int AnnoIscrizione { get; set; }
        string Denominazione{ get; }

       
    }

    class Persona : IUtente{

        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Denominazione
        {
            get
            {
                return $"{this.Id}: {this.Nome} {this.Cognome}";
            }
        }

        //oppure
        //public string Denominazione => $"{this.Id}: {this.Nome} {this.Cognome}";
    }

    public class Organizzazione : IUtente {

        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }

        public string RagioneSociale{ get; set; }

        public string Denominazione
        {
            get
            {
                return $"{this.Id}: {this.RagioneSociale}";
            }
        }
    }

    //public class Stampa
    //{

    //}




    //internal class Libro {
    //    internal string Id {  get; set; }
    //    internal string Title { get; set; }
    //    internal string Author { get; set; }
    //    internal Utente Utente { get; set; }

    //    internal string Descrizione
    //    {
    //        get
    //        {
    //            return $"{Title} di {Author}";
    //        }
    //    }

    //    internal Libro() { }
        //internal Libro(string id, string title, string author)
        //{
        //    this.Id = id;
        //    this.Title = title;
        //    this.Author = author;
        //}

        //internal void Prestito(Utente? utente) {

        //    //var locale e non d'istana
        //    if (utente == null) { } 


        //    if (this.Utente == null)
        //        this.Utente = utente;
        //    else
        //        Console.WriteLine("Libro già in prestito");
        //}
        //internal void Restituzione()
        //{
        //    Console.WriteLine(
        //        $"Libro {Title} restituito da {Utente.Denominazione}");
        //    this.Utente = null;
        //}

    //}

}