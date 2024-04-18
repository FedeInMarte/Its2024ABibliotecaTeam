using System;

public class User
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int SubYear { get; set; }


    public User(string id, string name, string lastName, int subYear)
    {
        this.Id = id;
        this.Name = name;
        this.LastName = lastName;
        this.SubYear = subYear;
    }


    public string Denominazione
    {
        get
        {
            return $"'{this.Name} {this.LastName}'";
        }
    }


    public void OnReturn<T>(T source, EventArgs e) where T: Book
    {
        Console.WriteLine($"{this.Denominazione} il libro {source.Descrizione} che avevi richiesto è ora disponibile per il Prestito!");
    }

}
