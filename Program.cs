// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

internal class Program
{

        static public IUtente[] Test_Utenti()
        {
            string[] Nomi = ["francesco", "luca", "paolo", "gianluca", "peppe"];
            string[] Cognomi = ["Grelli", "gianotti", "Bitta", "Romei", "Bucchi"];
            string[] Ragione = ["Tera", "Mela", "BANANA",];
            IUtente[] Utenti = new IUtente[5];



            for (int i = 0; i < 3; i++)
            {
                Utenti[i] = new Persona($"{i}", Nomi[i], Cognomi[i]);
            }
            for (int i = 3; i < 5; i++)
            {
                Utenti[i] = new Organizzazione($"{i}", Ragione[i - 3]);
            }
            return Utenti;
        }

        static public void StampaUtenti(IUtente[] Utenti)
        {
            foreach (var utente in Utenti)
            {
                Console.WriteLine(utente.Denominazione);
            }
        }



    static IUtente[] utenti = Test_Utenti();

    private static void Main(string[] args)
    {

        
        StampaUtenti(utenti);

        
    }
}