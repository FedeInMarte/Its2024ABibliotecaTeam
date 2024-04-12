namespace esercizio2 {
    public class Vehicle {
        protected string Color { get; set; } //Hex color
        public string Dettagli {
            get {
                return "vehicle: ["
                    + $"\ncolor: {Color}"
                    + "\n]";
            }
        }

        public Vehicle(string color) {
            Color = color;
        }
    }
}