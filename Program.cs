using Its2024ABibliotecaTeam;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

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
            Persona daniele = new Persona("0001", "daniele", "beltrami", 2015);
            Persona pippo = new Persona("0002", "Pippo", "ippopotamo", 2018);
            Persona pluto = new Persona("0003", "pluto", "cane",2020);
            Organizzazione WWF = new Organizzazione("0001", 2015, "uccidere gli animali");
            Libro isda = new Libro("001", "il signore degli anelli", "J.R.R. Tolkien");
            //Utenti[0]=(pippo);

            //Utenti[1]=(WWF);
            //StampaUtente();
            isda.LibroDisponibile += pippo.Sottoscrizione;
            isda.LibroDisponibile += daniele.Sottoscrizione;
            isda.Prestito(pluto);
            isda.Restituzione();
            

        }
    }

   

    public class Libro {
        internal string Id { get; set; }
        internal string Title {  get; set; }
        internal string Author {  get; set; }
         internal string Descrizione{
            get{return $"{Title} di {Author}";}
        }
         public event Action<string, Libro>? LibroDisponibile;
        
        private Persona utente;
    
        public Libro(string id, string title, string author)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
        }

        public void Prestito(Persona? utente) {

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
            if(LibroDisponibile != null)
            LibroDisponibile(this.Descrizione, this);
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
    public void Sottoscrizione(string titolo, Libro restituito)
    {
        
        Console.WriteLine($"il libro {titolo} è ora disponibile ");
       
      restituito.Prestito(this);


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