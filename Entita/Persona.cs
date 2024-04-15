
namespace Its2024ABibliotecaTeam.Entita
{
    internal class Persona : IUtente
    {
        internal string Name { get; set; }
        internal string Surname { get; set; }
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione
        {
            get
            {
                return $"{Id} {Name} {Surname}";
            }
        }
    }
}
