namespace bibliotecamoderna {
    public interface IUser {
        string Id { get; set; }
        int YearSubscription { get; set; }
        string Denomination { get; }
    }
}