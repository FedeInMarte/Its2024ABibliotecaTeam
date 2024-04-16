using System;

namespace Its2024ABibliotecaTeam
{
    public interface IUtente
    {
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione { get; }
    }
}