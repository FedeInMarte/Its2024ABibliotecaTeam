public class Book {
    private string Id { get; }
    private string Title;
    private string Author;
    public User? User { get; private set; }

    public Book(string id, string title, string author) {
        Id = id;
        Title = title;
        Author = author;
    }

    public string Description() { return $"{Title} of {Author}"; }

    public void Lend(User user) {
        if(User != null) {
            Console.WriteLine($"Libro {Id} già prestato a {User.FullName()}");
            return;
        }

        User = user; 
        Console.WriteLine($"Libro {Id} prestato a {User.FullName()}");
    }

    public void Return() {
        if(User == null) {
            Console.WriteLine($"Il libro {Id} è ancora in biblioteca");
            return;
        }

        User = null; 
        Console.WriteLine($"Libro {Id} restituito"); 
    }
}