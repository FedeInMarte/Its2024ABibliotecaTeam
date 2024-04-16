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
            get{return $"{Title} di {Author}";}
        }
         public event Action<string> LibroDisponibile;
    

        

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
            LibroDisponibile(this.Descrizione);
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
    public string Denominazione => $"{this.Id}-->{this.Nome} {this.Cognome}";
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

    public string Denominazione => $"{this.Id}:  {this.RagioneSociale}";
    string RagioneSociale { get; set; }


   public Organizzazione(string id, int annoIscrizione, string ragioneSociale)
    {
        Id = id;
        AnnoIscrizione = annoIscrizione;
        RagioneSociale = ragioneSociale;
    }
}