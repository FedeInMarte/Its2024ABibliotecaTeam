namespace bibliotecamoderna {
    public class Person : IUser {
        public string Id { get; set; }
        public int YearSubscription { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Denomination => Id + "_" + Name + "_" + Surname;

        public Person(string id, int yearSubscription, string name, string surname) {
            Id = id;
            YearSubscription = yearSubscription;
            Name = name;
            Surname = surname;
        }
    }
}