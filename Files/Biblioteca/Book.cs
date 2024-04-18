using System;
using System.Collections.Generic;
using System.Reflection;

public class Book
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public User? User { get; set; }

    private List<User> subs = new List<User>();  // Lista per la gestione di prestito al primo subscriber dopo la restituzione

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
        if (this.User == user)
        {
            Console.WriteLine($"{this.User.Denominazione} possiedi gia' {this.Descrizione}!");
        }
        else if (this.User != null)
        {
            Console.WriteLine($"{user.Denominazione} non puoi prendere {this.Descrizione}, è già in prestito da {this.User.Denominazione}");
            //sottoscrizione di user al libro che desidera. Quando qualcuno lo restituirà riceverà una notifica
            this.BookReturned += user.OnReturn;
            subs.Add(user);
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
            //Implementazione del metodo OnReturn sottostante direttamente qua
            if (BookReturned != null)
            {
                BookReturned?.Invoke(this, EventArgs.Empty);
                this.User = subs[0];  // Il primo subscriber riceve in prestito il libro
                subs.RemoveAt(0); // Rimozione di tale subscriber dalla lista
                Console.WriteLine($"{this.User.Denominazione} prestito del libro {this.Descrizione} avvenuto automaticamente!");
            }
        }
        else
        {
            Console.WriteLine($"{this.Descrizione} è disponibile per il Prestito!");
        }
    }

    //protected virtual void OnReturn()
    //{
    //    if (BookReturned != null)
    //    {
    //        BookReturned?.Invoke(this, EventArgs.Empty);
    //        this.User = subs[0];  // Il primo subscriber riceve in prestito il libro
    //        subs.RemoveAt(0); // Rimozione di tale subscriber dalla lista
    //        Console.WriteLine($"{this.User.Denominazione} prestito del libro {this.Descrizione} avvenuto automaticamente!");
    //    }

    //}


}
