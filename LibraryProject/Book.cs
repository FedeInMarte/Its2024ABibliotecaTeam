public delegate void BookEventHandler<TEventArgs>(Book sender, TEventArgs e) where TEventArgs : EventArgs;

public class Book {
    private string Id { get; }
    private string Title;
    private string Author;
    public string Description {
        get {
            return $"{Title} of {Author}";
        }
    }
    public User? User { get; private set; }
    public event BookEventHandler<EventArgs>? OnLend;
    public event BookEventHandler<EventArgs>? OnReturn;

    public Book(string id, string title, string author) {
        Id = id;
        Title = title;
        Author = author;
    }

    public void Lend(User user) {
        if(User != null) {
            Console.WriteLine($"Libro {Id} già prestato a {User.FullName}");
            return;
        }

        User = user; 
        OnLend?.Invoke(this, EventArgs.Empty);
        Console.WriteLine($"Libro {Id} prestato a {User.FullName}");
    }

    public void Return() {
        if(User == null) {
            Console.WriteLine($"Il libro {Id} è ancora in biblioteca");
            return;
        }

        User = null; 
        OnReturn?.Invoke(this, EventArgs.Empty);
        Console.WriteLine($"Libro {Id} restituito"); 
    }
}