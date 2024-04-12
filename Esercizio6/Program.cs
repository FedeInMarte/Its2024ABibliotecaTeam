namespace esercizio2 {
    public class Program {
        static void Main(string[] args) {
            Init();


            Wait();
        }

        private static string InsertString(string message) {
            Console.Write(message);
            string? inputUser = Console.ReadLine();
            return inputUser ?? "";
        }

        private static int InsertInt(string message) {
            Console.Write(message);

            while (true) {
                string? inputUser = Console.ReadLine();

                if (int.TryParse(inputUser, out int number)) {
                    return number;
                } else {
                    Console.WriteLine("Errore, inserisci di nuovo il numero: ");
                }
            }
        }

        private static double InsertDouble(string message) {
            Console.Write(message);

            while (true) {
                string? inputUser = Console.ReadLine();

                if (double.TryParse(inputUser, out double number)) {
                    return number;
                } else {
                    Console.WriteLine("Errore, inserisci di nuovo il numero: ");
                }
            }
        }

        private static void Init() {
            Console.Title = "Prova";
        }

        private static void Wait() {
            Console.Write("Premi un pulsante per uscire...");
            Console.ReadLine();
        }
    }
}
