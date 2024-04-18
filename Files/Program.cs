﻿using System;

namespace Its2024ABibliotecaTeam
{
    public class Program
    {
        public static IUtente[] utenti;

        public static void Main(string[] args)
        {
            // Biblioteca esercizio 1
            Console.Clear();


            User fr = new User("0001", "Francesco", "Renghi", 2019);  //subscriber
            User bj = new User("0002", "Jamal", "Benkhalek", 2023);   //subscriber

            Book commedia = new Book("0001", "La Divina Commedia", "Dante Alighieri");  //publisher
            Book Dune = new Book("0002", "Dune", "Frank Herbert");

            LibroHorror OmbraScorpione = new LibroHorror("0003", "L'Ombra dello Scorpione", "Stefano Re", 6);
            OmbraScorpione.GradoDiSpavento = 4;

            Book[] listaLibri = { commedia, OmbraScorpione };

            Console.WriteLine("Lista dei Libri:");
            foreach (Book b in listaLibri)
            {
                Console.WriteLine(b.Descrizione);
            }
            Console.WriteLine();


            commedia.Loan(fr); //fr prende commedia
            Console.ReadKey();

            commedia.Loan(bj); //bj prova a prendere commedia, risultato negativo ma verrà avvisato alla restituzione
            Console.ReadKey();

            commedia.Return(); //fr restituisce commedia. bj viene avvisato
            Console.ReadKey();

            commedia.Loan(bj); //bj finalmente può prendere commedia
            Console.ReadKey();







            // BibliotecaModerna esercizio 3

            // Dichiarazione Variabili necessarie
            Console.Clear();
            string id, name, lastName, ragioneSociale;
            int annoIscrizione;


            Console.Write("Quanti utenti vuoi creare? ");
            int dim = Convert.ToInt32(Console.ReadLine());

            // Inizializzazione attributo statico array di utenti con dimensione fissata
            utenti = new IUtente[dim];


            // Richiesta parametri per creare con l'Object Initializer ogni Persona/Organizzazione e aggiunta nell'array
            for (int i = 0; i < dim; i++)
            {
                Console.Write("Vuoi creare:\n1) Persona\n2) Organizzazione?\nScegli: ");
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Console.Write("Inserisci ID: ");
                        id = Console.ReadLine();
                        Console.Write("Inserisci Anno Iscrizione: ");
                        annoIscrizione = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Inserisci Nome: ");
                        name = Console.ReadLine();
                        Console.Write("Inserisci Cognome: ");
                        lastName = Console.ReadLine();

                        IUtente u = new Persona
                        {
                            Id = id,
                            AnnoIscrizione = annoIscrizione,
                            Name = name,
                            LastName = lastName
                        };

                        utenti[i] = u;
                        break;
                    case "2":
                        Console.Write("Inserisci ID: ");
                        id = Console.ReadLine();
                        Console.Write("Inserisci Anno Iscrizione: ");
                        annoIscrizione = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Inserisci Ragione Sociale: ");
                        ragioneSociale = Console.ReadLine();

                        IUtente or = new Organizzazione
                        {
                            Id = id,
                            AnnoIscrizione = annoIscrizione,
                            RagioneSociale = ragioneSociale
                        };

                        utenti[i] = or;
                        break;
                }

                Console.Write("Premere un tasto per continuare . . .");
                Console.ReadKey();
                Console.Clear();

            }

            // Stampa di ogni istanza IUtente presente nell'array
            Console.WriteLine("Utenti presenti nella lista:");
            StampaUtente(utenti);




        }




        // Metodo statico per la stampa di tutti gli utenti presenti in una lista
        static void StampaUtente(IUtente[] listaUtenti)
        {
            foreach (IUtente u in listaUtenti)
            {
                if (u != null)
                {
                    Console.WriteLine(u.Denominazione);
                }
                else
                {
                    throw new Exception("Errore Imprevisto !");
                }
            }
        }
        




    }
}
