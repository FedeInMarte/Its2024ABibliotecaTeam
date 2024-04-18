using System;
using System.Collections.Generic;
using System.Reflection;

public class Book
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public User? User { get; set; }

    // Dizionario per la gestione dei subscribers presenti per ogni libro
    private Dictionary<Book, List<User>> subscribers = new Dictionary<Book, List<User>>();

    public delegate void BookReturnedEventHandler<T>(T sender, EventArgs args) where T : Book;  //delegate
    public event BookReturnedEventHandler<Book>? BookReturned;  // event


    public Book(string id, string title, string author)
    {
        this.Id = id;
        this.Title = title;
        this.Author = author;
    }

    public string Descrizione => $"'{this.Title.ToUpper()}' di '{this.Author.ToUpper()}'";

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
            // Creazione di una nuova lista di subscribers se il libro e' stato richiesto da piu' persone
            if (!subscribers.ContainsKey(this))
            {
                subscribers[this] = new List<User>();
            }
            // Aggiunta dell'interessato alla Lista se non già presente
            if (!subscribers[this].Contains(user))
            {
                subscribers[this].Add(user);
                Console.WriteLine($"{user.Denominazione} iscrizione al libro {this.Descrizione} avvenuto con successo!");
            }
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
                if(subscribers.ContainsKey(this) && subscribers[this].Count > 0)
                {
                    // Modifica del proprietario del prestito con il primo subscribers nella Lista
                    this.User = subscribers[this][0];
                    subscribers[this].RemoveAt(0);
                    Console.WriteLine($"{this.User.Denominazione} prestito del libro {this.Descrizione} avvenuto automaticamente!");
                }
            }
        }
        else
        {
            Console.WriteLine($"{this.Descrizione} è disponibile per il Prestito!");
        }
    }
}
