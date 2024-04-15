using Its2024ABibliotecaTeam.Entita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2024ABibliotecaTeam
{
    internal class StaticMethods
    {
        internal static void addPerson(List<IUtente> u)
        {
            Persona p = new Persona();
            Console.WriteLine("Inserisci nome");
            p.Name = Console.ReadLine();
            Console.WriteLine("Inserisci cognome");
            p.Surname = Console.ReadLine();
            Console.WriteLine("Inserisci id");
            p.Id = Console.ReadLine();
            Console.WriteLine("Inserisci anno iscrizione");
            string annoIscr = Console.ReadLine();
            while (int.TryParse(annoIscr, out _) == false)
            {
                Console.WriteLine("Anno iscrizione non valido, riprova");
                annoIscr = Console.ReadLine();
            }
            p.AnnoIscrizione = Convert.ToInt32(annoIscr);
            u.Add(p);
        }
        internal static void addOrganisation(List<IUtente> u) {
            Organizzazione o = new Organizzazione();
            Console.WriteLine("Inserisci Ragione sociale");
            o.RagioneSociale = Console.ReadLine();
            Console.WriteLine("Inserisci id");
            o.Id = Console.ReadLine();
            Console.WriteLine("Inserisci anno iscrizione");
            string annoI = Console.ReadLine();
            while (int.TryParse(annoI, out _) == false)
            {
                Console.WriteLine("Anno iscrizione non valido, riprova");
                annoI = Console.ReadLine();
            }
            o.AnnoIscrizione = Convert.ToInt32(annoI);
            u.Add(o);
        }
    }
}
