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
