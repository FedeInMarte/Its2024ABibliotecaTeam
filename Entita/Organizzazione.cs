
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
    }
}
