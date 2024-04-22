using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2024ABibliotecaTeam
{
    interface IUtente
    {
        string Id { get; set; }
        int AnnoIscrizione { get; set; }
        string Denominazione { get; }
    }

    class Persona : IUtente
    {
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public string Denominazione
        {
            get
            {
                return $"{this.Id} {this.Nome} {this.Cognome}";
            }
        }

        public void Interesse(Libro libro)
        {
            //libro.OnReturn += (sender, args) => {
            //    Console.WriteLine($"{libro} e' tornato disponibile");
            //};
            libro.LibroDisponibileMessage += MessageHandler;
            Console.WriteLine($"Io {this.Denominazione} sono interessato a leggere {libro.Descrizione}");
        }

        public void MessageHandler(string message)
        {
            Console.WriteLine($" Io sono {this.Denominazione} e mi è arrivato questo messaggio:{message}" );
        }
    }
    class Organizzazione : IUtente
    {
        string RagioneSociale { get; set; }
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione => $"{this.Id} {this.RagioneSociale}";


        public Organizzazione(
            string ragioneSociale,
            string id,
            int annoIscrizione
            )
        {
            this.RagioneSociale = ragioneSociale;
            this.Id = id;
            this.AnnoIscrizione = annoIscrizione;
        }
    }

    //internal class Utente
    //{
    //    internal string Id { get; set; }
    //    internal string Name { get; set; }
    //    internal string Surname { get; set; }
    //    internal int AnnoIscrizione { get; set; }
    //    internal int Anno { get; set; }

    //    internal string Denominazione
    //    {
    //        get { return $"{Name} {Surname}"; }
    //    }


    //    internal Utente(string id,
    //        string name,
    //        string surname,
    //        int annoIscrizione)
    //    {
    //        this.Id = id;
    //        this.Name = name;
    //        this.Surname = surname;
    //        this.AnnoIscrizione = annoIscrizione;
    //    }
    //}

}
