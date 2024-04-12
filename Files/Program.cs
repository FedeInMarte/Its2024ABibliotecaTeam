using System;

internal class Library
    {
        public static void Main(string[] args)
        {
            Console.Clear();


            User user1 = new User("0001", "Francesco", "Renghi", 2019);
            User user2 = new User("0002", "Jamal", "Benkhalek", 2023);

            Book Commedia = new Book("0001", "La Divina Commedia", "Dante Alighieri");
            Book Dune = new Book("0002", "Dune", "Frank Herbert");

            LibroHorror OmbraScorpione = new LibroHorror("0003", "L'Ombra dello Scorpione", "Stefano Re", 6);
            OmbraScorpione.GradoDiSpavento = 4;

            Book[] listaLibri = {Commedia, OmbraScorpione};

            foreach(Book b in listaLibri){
                Console.WriteLine(b.Descrizione);
            }


            Commedia.Loan(user1);
            Console.ReadKey();
            Commedia.Loan(user2);
            Console.ReadKey();
            Commedia.Return();
            Console.ReadKey();
            Dune.Return();
            Console.ReadKey();
            Commedia.Loan(user2);
            Console.ReadKey();
        }
    }