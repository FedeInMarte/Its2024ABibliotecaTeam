using System;

namespace Its2024ABibliotecaTeam
{
    public class Persona : IUtente
    {
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione
        {
            get
            {
                return $"{this.Id} {this.Name} {this.LastName}";
            }
        }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}