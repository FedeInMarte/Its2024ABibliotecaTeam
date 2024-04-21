using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2024ABibliotecaTeam
{
    internal class LibroHorror : Libro
    {
        internal int GradoDiSpavento { get; set; }
        internal LibroHorror(string id, string title, string author, int gradoDiSpavento) 
            : base(id, title, author)
        {
            GradoDiSpavento = gradoDiSpavento;
            Id = id;
        }

        internal string Spaventami()
        {
            return $"Buuuuuuhhh {Id}";
        }
        internal void Prestito(Persona? utente)
        {

            //var locale e non d'istana
            if (utente == null) { }


            if (this.Utente == null)
                this.Utente = utente;
            else
                Console.WriteLine("Libro già preso in prestito da qualcuno coraggioso");
        }
    }
}
