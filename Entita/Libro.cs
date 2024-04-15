
namespace Its2024ABibliotecaTeam.Entita
{
    internal class Libro
    {
        internal string Id { get; set; }
        internal string Title { get; set; }
        internal string Author { get; set; }
        internal IUtente? Utente { get; set; }
        internal string Descrizione
        {
            get
            {
                return $"{Title} di {Author}";
            }
        }

        internal Libro(string id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        internal void Prestito(IUtente? utente)
        {

            //var locale e non d'istana
            if (utente == null) { }


            if (Utente == null)
                Utente = utente;
            else
                Console.WriteLine("Libro già in prestito");
        }
        internal void Restituzione()
        {
            Console.WriteLine(
                $"Libro {Title} restituito da {Utente.Denominazione}");
            Utente = null;
        }

    }
}
