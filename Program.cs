using System.Runtime.CompilerServices;
using static Its2024ABibliotecaTeam.Persona;

namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUtente[] utenti;
            static void StampaUtente(IUtente[] arr)
            {
                foreach (IUtente utenti in arr)
                    Console.WriteLine(utenti.Denominazione);
            }
            IUtente p = new Persona("62251 ","Tommaso ", "Pomi ", 2024);
            IUtente o = new Organizzazione("001","Viva");

            utenti = new IUtente[] {p, o};
            StampaUtente(utenti);
            
        }
    }

    public interface IUtente {

        
        string Id { get; set; }
        int AnnoIscrizione { get; set; }

        public string Denominazione { get; } 
    }

    class Persona : IUtente
    {
        string Nome { get; set; }
        string Cognome { get; set; }

        public Persona(string id, string nome, string cognome, int AnnoI)
        {

            this.Id = id;
            this.Nome = nome;
            this.Cognome = cognome;
            this.AnnoIscrizione = AnnoI;

        }
        public string Id { get; set; }
        public int AnnoIscrizione { set; get; }
        public string Denominazione
        {
            get { return $"{Id}{Nome}{Cognome}"; }
        }




        public class Organizzazione : IUtente
        {
            public string Id { get; set; }
            public int AnnoIscrizione { get; set; }

            public Organizzazione(string id, string ragioneSociale)
            {
                this.Id = id;
                this.RagioneSociale = ragioneSociale;
            }

            public string Denominazione
            {
                get { return $"{Id} {RagioneSociale}"; }
            }

            public string RagioneSociale { get; set; }
        }
    }

}
