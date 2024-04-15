namespace bibliotecamoderna {
    public class Organization : IUser {
        public string Id { get; set; }
        public int YearSubscription { get; set; }
        public string SocialReason { get; set; }
        public string Denomination => Id + "_" + SocialReason;

        public Organization(string id, int yearSubscription, string socialReason) {
            Id = id;
            YearSubscription = yearSubscription;
            SocialReason = socialReason;
        }
    }
}