using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2024ABibliotecaTeam
{
    public delegate void BookEventHandler<T>(Libro sender, T data) where T : EventArgs;

    public class Libro {
        protected string Id { get; set; }
        internal string Title { get; set; }
        internal string Author { get; set; }


        //private string message;

        //public string Message { 
        //    get { return message; }
        //    set { message = value; OnNewMessage(message); }
        //        }
        

        public event BookEventHandler<EventArgs> OnReturn;

        internal string Descrizione
        {
            get { return $"{Title} di {Author}"; }

        }
       

        internal Utente Utente { get; set; }

        internal Libro(string id, string title, string author)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
        }

        internal void Prestito(Utente? utente) {

            //var locale e non d'istana
            if (utente == null) { }


            if (this.Utente == null)
            {
                this.Utente = utente;
                
            }
            else
                Console.WriteLine("Libro già in prestito");
        }
        internal void Restituzione()
        {
            Console.WriteLine(
                $"Libro {Title} restituito da {Utente.Denominazione}");
            this.Utente = null;
            OnReturn?.Invoke(this, EventArgs.Empty);
            
        }



    }

}
