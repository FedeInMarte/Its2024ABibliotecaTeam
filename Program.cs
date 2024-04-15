internal class Program
{
    internal static IUtente[] utenti;
    static void Stampautente(IUtente[] ar )
    {
        foreach(IUtente utenti in ar)
        {
            Console.WriteLine(utenti.Denominazione);
        }
    }
    static void Main(string[] args)
    {
        //Utente Fausto = new Utente("000001", "Fausto", "Ponsi", 2024);
        //Utente Pierpaolo = new Utente("000002", "Pierpaolo", "Cozzi", 2024);


        //Libro It = new Libro("001", "It", "Giammarco Tocco");
        //It.Prestito(Fausto);
        //It.Prestito(Pierpaolo);
        //It.Prestito(null);

        //It.Restituzione();
        //It.Prestito(Pierpaolo);

        IUtente massimo = new Persona { Id = "01", AnnoIscrizione = 2021, Nome = "massimo", Cognome = "oddo", };
        IUtente favalli = new Organizzazione { Id = "02", AnnoIscrizione = 2022, RagioneSociale = "alberobello" };
        utenti= new IUtente[] { massimo, favalli };
        Stampautente(utenti);    

    }
}

internal class Utente
{
    internal string Id { get; set; }
    internal string Name { get; set; }
    internal string Surname { get; set; }
    internal int AnnoIscrizione { get; set; }
    internal string Denominazione
    {
        get { return $"{Name}{Surname}"; }
    }
    internal Utente(string id,
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

internal class Libro
{
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

    internal void Prestito(Utente? utente)
    {

       
        if (utente == null) { }


        if (this.Utente == null)
            this.Utente = Utente;
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
interface IUtente
{
    string Id { get; set; }
    int AnnoIscrizione { get; set; }
    string Denominazione { get; }
}
internal class Persona : IUtente
{
    internal string Nome { get; set; }
    internal string Cognome { get; set; }

    public string Id { get; set; }
    public int AnnoIscrizione { get; set; }
    public string Denominazione
    {
        get
        {
            return $"{Nome} {Cognome}";
        }
    }
    //public Persona(string nome, string cognome, string id, int annoIscrizione)
    //{
    //    this.Nome = nome;
    //    this.Cognome = cognome;
    //    this.Id = id;
    //    this.AnnoIscrizione = annoIscrizione;
    //}
}
 internal class Organizzazione : IUtente
{
    public string Id { get; set; }
    public int AnnoIscrizione { get; set; }
    public string Denominazione
    {
        get
        {
            return $"{Id} {RagioneSociale}";
        }
    }
    public string RagioneSociale { get; set; }
}

