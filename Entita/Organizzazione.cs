
namespace Its2024ABibliotecaTeam.Entita
{
    internal class Organizzazione : IUtente
    {
        internal string RagioneSociale { get; set; }
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione
        {
            get
            {
                return $"{Id} {RagioneSociale}";
            }
        }
        internal Organizzazione()
        {
            Console.WriteLine("Inserisci Ragione sociale");
            RagioneSociale = Console.ReadLine();
            Console.WriteLine("Inserisci id");
            Id = Console.ReadLine();
            Console.WriteLine("Inserisci anno iscrizione");
            string annoI = Console.ReadLine();
            while (int.TryParse(annoI, out _) == false)
            {
                Console.WriteLine("Anno iscrizione non valido, riprova");
                annoI = Console.ReadLine();
            }
            AnnoIscrizione = Convert.ToInt32(annoI);
        }
    }
}
