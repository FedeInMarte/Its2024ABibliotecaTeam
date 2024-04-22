namespace bibliotecamoderna {
    public class Program {
        private static List<IUser> users = new List<IUser>();
        /*
        static void Main(string[] args) {
            Init();

            Person person1 = new Person("0001",2001,"Cesare","Diodato");
            Organization organization1 = new Organization("0001",2000,"Boh");

            users.Add(person1);
            users.Add(organization1);

            printUsers();

            Wait();
        }*/

        private static void printUsers() {
            Console.WriteLine("users: [");

            foreach(IUser user in users) {
                Console.WriteLine(
                    user.Equals(users.Last())
                        ? $"    user: {user.Denomination}"
                        : $"    user: {user.Denomination},"
                );
            }

            Console.WriteLine("]");
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
            Console.WriteLine("Premi un pulsante per uscire...");
            Console.ReadLine();
        }
    }
}
