using System;

namespace Its2024ABibliotecaTeam
{
    public class Organizzazione : IUtente
    {
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione
        {
            get
            {
                return $"{this.Id} {this.RagioneSociale}";
            }
        }
        public string RagioneSociale { get; set; }
    }
}