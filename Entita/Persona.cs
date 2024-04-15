
namespace Its2024ABibliotecaTeam.Entita
{
    internal class Persona : IUtente
    {
        //PROPERTIES
        internal string? Name { get; set; }
        internal string? Surname { get; set; }
        public string? Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione
        {
            get
            {
                return $"{Id} {Name} {Surname}";
            }
        }

        //CONSTRUCTOR
        internal Persona()
        {
            Console.WriteLine("Inserisci nome");
            Name = Console.ReadLine();
            Console.WriteLine("Inserisci cognome");
            Surname = Console.ReadLine();
            Console.WriteLine("Inserisci id");
            Id = Console.ReadLine();
            Console.WriteLine("Inserisci anno iscrizione");
            string? annoIscr = Console.ReadLine();
            while (int.TryParse(annoIscr, out _) == false || Convert.ToInt32(annoIscr) < 2000)
            {
                Console.WriteLine("Anno iscrizione non valido, riprova");
                annoIscr = Console.ReadLine();
            }
            AnnoIscrizione = Convert.ToInt32(annoIscr);
        }
    }
}
