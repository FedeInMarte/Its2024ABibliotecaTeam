using System.Linq.Expressions;

namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        static IUtente[]? Utenti;
        static void  StampaUtente()
        {
            foreach (IUtente elem in Utenti)
            {
                if (elem != null)
                {
                    Console.WriteLine(elem.Denominazione);

                }   
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
            Utenti = new IUtente[5];
            Persona pippo = new Persona("qweas2", "Pippo", "Arciboldi", 2018);
            Organizzazione WWF = new Organizzazione("0001", 2015, "uccidere gli animali");
            Utenti[0]=(pippo);
            Utenti[1]=(WWF);
            StampaUtente();
        }
    }

   

    internal class Libro {
        internal string Id { get; set; }
        internal string Title {  get; set; }
        internal string Author {  get; set; }
         internal string Descrizione{
            get{
                return $"{Title} di {Author}";
            }
        }
        private Persona utente;
    
        internal Libro(string id, string title, string author)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
        }

        internal void Prestito(Persona? utente) {

            //var locale e non d'istanza
            if (utente == null) { } 


            if (this.utente == null)
                this.utente = utente;
            else
                Console.WriteLine("Libro già in prestito");
        }
        internal void Restituzione()
        {
            Console.WriteLine(
                $"Libro {Title} restituito da {utente.Denominazione}");
            this.utente = null;
        }

    }

}
 interface IUtente
{
    string Id { get; set; }
    int AnnoIscrizione {  get; set; }
    string Denominazione { get; }

}
public class Persona : IUtente
{
    public string Id { get; set; }
    public int AnnoIscrizione { get; set; }
    public string Denominazione { get { return $"{Id}-->{Nome} {Cognome}"; } }
    string Nome { get; set; }
    string Cognome { get; set; }

    public Persona(string id,
            string name,
            string surname,
            int annoIscrizione)
    {
        this.Id = id;
        this.Nome = name;
        this.Cognome = surname;
        this.AnnoIscrizione = annoIscrizione;
    }
}
public class Organizzazione : IUtente
{
    public string Id { get ; set ; }
    public int AnnoIscrizione { get ; set ; }

    public string Denominazione { get { return $"{Id}:  {RagioneSociale}"; } }
    string RagioneSociale { get; set; }


   public Organizzazione(string id, int annoIscrizione, string ragioneSociale)
    {
        Id = id;
        AnnoIscrizione = annoIscrizione;
        RagioneSociale = ragioneSociale;
    }
}