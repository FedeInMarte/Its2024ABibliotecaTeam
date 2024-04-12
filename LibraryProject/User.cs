public class User {
    private string Id;
    private string Name;
    private string Surname;
    public string FullName { 
        get {
            return $"{Name} {Surname}"; 
        }
    }
    private int YearSubscription;

    public User(string id, string name, string surname, int yearSubscription) {
        Id = id;
        Name = name;
        Surname = surname;
        YearSubscription = yearSubscription;
    }
}