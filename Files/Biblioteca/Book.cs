using System;

public delegate void BookEventHandler<T> (T sender, T data) where T: EventArgs;

public class Book
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public User? User { get; set; }


    private string message;


    public string Message
    {
        get { return message; }
        set { message = value; OnNewMessage(message); }
    }


    public event BookEventHandler<EventArgs> OnReturn;

    public void OnNewMessage(string msg)
    {
        //if (OnReturn != null)
            //OnReturn(msg);
    }


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
            return $"{this.Title} di {this.Author}";
        }

    }

    public void Loan(User user)
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

    public void Return()
    {

        if (this.User != null)
        {
            Console.WriteLine($"{this.User.Denominazione} ha restituito {this.Descrizione}");
            this.User = null;
            //OnReturn?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            Console.WriteLine($"{this.Descrizione} è disponibile per il Prestito!");
        }
    }

}
