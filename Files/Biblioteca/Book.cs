using System;
using System.Reflection;

public class Book
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public User? User { get; set; }

    public delegate void BookReturnedEventHandler<T>(T sender, EventArgs args) where T : Book;  //delegate
    public event BookReturnedEventHandler<Book>? BookReturned;  // event


    public Book(string id, string title, string author)
    {
        this.Id = id;
        this.Title = title;
        this.Author = author;
    }

    public string Descrizione
    {
        get
        {
            return $"'{this.Title}' di '{this.Author}'";
        }

    }

    public void Loan(User user)
    {

        if (this.User != null)
        {
            Console.WriteLine($"{user.Denominazione} non puoi prendere {this.Descrizione}, è già in prestito da {this.User.Denominazione}");
            this.BookReturned += user.OnReturn;  //sottoscrizione di user al libro che desidera. Quando qualcuno lo restituirà riceverà una notifica
        }
        else
        {
            this.User = user;
            Console.WriteLine($"{this.Descrizione}: prestito effettuato a {user.Denominazione}");
        }
    }

    public void Return()
    {

        if (this.User != null)
        {
            Console.WriteLine($"{this.User.Denominazione} ha restituito {this.Descrizione}");
            this.User = null;
            OnReturn();
        }
        else
        {
            Console.WriteLine($"{this.Descrizione} è disponibile per il Prestito!");
        }
    }

    protected virtual void OnReturn()
    {
        if (BookReturned != null)
            BookReturned?.Invoke(this, EventArgs.Empty);
    }


}
