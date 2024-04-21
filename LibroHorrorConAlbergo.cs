using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2024ABibliotecaTeam
{
    internal class LibroHorrorConAlbergo : LibroHorror
    {


        internal LibroHorrorConAlbergo(string id, string title, string author, int gradoDiSpavento) : base(id, title, author, gradoDiSpavento)
        {
            Id = "dasasd";
        }
        internal void Prestito(Persona? utente)
        {
            Console.WriteLine("Attenzione contenuto pericoloso");
            //var locale e non d'istanza
            if (utente == null) { }


            if (this.Utente == null)
                this.Utente = utente;
            else
                Console.WriteLine("Libro già preso in prestito da qualcuno coraggioso ma a cui piaciono gli alberghi");
        }
    }
}
