﻿namespace Its2024ABibliotecaTeam
{
    internal class Program
    {
        static IUtente[]? Utenti;

        static void StampaUtenti()
        {
            foreach(IUtente elem in Utenti)
            {
                if(elem != null)
                {
                    Console.WriteLine(elem.Denominazione);
                }
            }
        }
        static void Main(string[] args)
        {
            Utenti = new IUtente[2];

            Persona p1 = new Persona
            {
                Id = "p001",
                AnnoIscrizione = 2024,
                Nome = "Pippo",
                Cognome = "Rossi"
            };
            Organizzazione o1 = new Organizzazione("blablabla", "o001", 2024);

            Utenti[0] = p1;
            Utenti[1] = o1;

            //Utenti.Append(o1);
            //Utenti.Append(p1);

            StampaUtenti();












            //Utente Federico = new Utente("000001", "Federico", "Martelloni", 2024);
            //Utente Pino = new Utente("000002", "Pino", "Abetoni", 2024);

            //Libro It = new Libro("001", "It","Stefano Re");
            //It.Prestito(Pino);
            //LibroHorror OmbraScorpione = new LibroHorror("001", "L'ombra dello scorpione", "Stefano Re", 6);
            //OmbraScorpione.GradoDiSpavento = 4;
            //OmbraScorpione.Prestito(Pino);
            //Libro CopiaDiOmbraScorpione = OmbraScorpione;

            //LibroHorrorConAlbergo Shining = new LibroHorrorConAlbergo("007", "Shining", "Stefano Re", 7);
            //Shining.Prestito(Pino);
            ////LibroHorror Test = (LibroHorror)new Libro("001", "It", "Stefano Re");

            ////CopiaDiOmbraScorpione.gr

            //Libro[] ListaLibri = 
            //    new Libro[] {
            //        It,
            //        OmbraScorpione,
            //        Shining };

            //foreach (Libro libro in ListaLibri)
            //{
            //    //Console.WriteLine(libro.Descrizione);

            //    libro.Prestito(Federico);

            //}


            //It.Prestito(Federico);
            //It.Prestito(Pino);
            //It.Prestito(null);

            //It.Restituzione();
            //It.Prestito(Pino);
        }
    }

}