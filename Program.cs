namespace Its2024ABibliotecaTeam
{
    internal class Library
    {
        public static void Main(string[] args)
        {
            Console.Clear();


            User user1 = new User("0001", "Francesco", "Renghi", 2019);
            User user2 = new User("0002", "Jamal", "Benkhalek", 2023);

            Book book1 = new Book("0001", "La Divina Commedia", "Dante Alighieri");
            Book book2 = new Book("0002", "Dune", "Frank Herbert");
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

    internal class User
    {
        internal string Id { get; set; }
        internal string Name { get; set; }
        internal string LastName { get; set; }
        internal int SubYear { get; set; }


        internal User(string id, string name, string lastName, int subYear)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.SubYear = subYear;
        }


        internal string Denominazione
        {
            get
            {
                return $"{this.Name} {this.LastName}";
            }
        }

    }







    internal class Book
    {
        internal string Id { get; set; }
        internal string Title { get; set; }
        internal string Author { get; set; }
        internal User? User { get; set; }


        internal Book(string id, string title, string author)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
        }

        internal string Descrizione
        {
            get
            {
                return $"{this.Title} di {this.Author}";
            }

        }

        internal void Loan(User user)
        {

            if (this.User != null)
            {
                Console.WriteLine($"{user.Denominazione} non puoi prendere {this.Descrizione}, è già in prestito da {this.User.Denominazione}");
            }
            else
            {
                this.User = user;
                Console.WriteLine($"{this.Descrizione}: prestito effettuato a {user.Denominazione}");
            }
        }

        internal void Return()
        {

            if (this.User != null)
            {
                Console.WriteLine($"{this.User.Denominazione} ha restituito {this.Descrizione}");
                this.User = null;
            }
            else
            {
                Console.WriteLine($"{this.Descrizione} è disponibile per il Prestito!");
            }
        }

    }

}