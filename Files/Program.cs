using Its2024ABibliotecaTeam;

internal class Library
    {
        public static void Main(string[] args)
        {
            Console.Clear();


            User user1 = new User("0001", "Francesco", "Renghi", 2019);
            User user2 = new User("0002", "Jamal", "Benkhalek", 2023);

            Book book1 = new Book("0001", "La Divina Commedia", "Dante Alighieri");
            Book book2 = new Book("0002", "Dune", "Frank Herbert");

            LibroHorror OmbraScorpione = new LibroHorror("0003", "L'Ombra dello Scorpione", "Stefano Re", 6);
            OmbraScorpione.GradoDiSpavento = 4;

            book1.Loan(user1);
            Console.ReadKey();
            book1.Loan(user2);
            Console.ReadKey();
            book1.Return();
            Console.ReadKey();
            book2.Return();
            Console.ReadKey();
            book1.Loan(user2);
            Console.ReadKey();
        }
    }