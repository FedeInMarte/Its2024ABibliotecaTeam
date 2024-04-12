public class Library {
    public string Id { get; }
    public string Name { get; }
    public List<Book> Books { get; } = new List<Book>();

    public Library(string id, string name) {
        Id = id;
        Name = name;
    }
}