namespace esercizio1 {
    public class Program {
        //* Uncomment for testing
        /*static void Main(string[] args) {
            Init();

            int a = 7;
            int b = a;
            b = 5;

            Console.WriteLine($"a:{a} b:{b}");

            CustomClass customClass1 = new CustomClass(5,7);
            CustomClass customClass2 = customClass1;
            customClass1.A = 32;
            customClass1.B = 8;
            customClass2.A = 0;

            Console.WriteLine(
                $"CustomClass1.A:{customClass1.A} CustomClass1.B:{customClass1.B}"
                + $"\nCustomClass2.A:{customClass2.A} CustomClass2.B:{customClass2.B}"
            );
        
            Wait();
        }*/

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
