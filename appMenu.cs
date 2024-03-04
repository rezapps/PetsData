namespace PetsData
{
    public class AppMenu
    {
        private string? readResult;
        private string _menuOption = "";

        public void DisplayMenu(List<Animal> ourAnimals, int maxPets)
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
                Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
                Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
                Console.WriteLine(" 5. Edit an animal’s age");
                Console.WriteLine(" 6. Edit an animal’s personality description");
                Console.WriteLine(" 7. Display all cats with a specified characteristic");
                Console.WriteLine(" 8. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                    readResult = Console.ReadLine() ?? "";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                if (readResult != null)
                {
                    _menuOption = readResult.ToLower();
                }

                switch (_menuOption)
                {
                    case "1":
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        menuFunctions.ListAnimals(ourAnimals, maxPets);
                        Console.ResetColor();
                        break;
                    case "2":
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Press the Enter key to continue.");
                        Console.ForegroundColor = ConsoleColor.White;
                        readResult = Console.ReadLine() ?? "";
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        menuFunctions.AddNewPet(ourAnimals, maxPets, readResult ?? "");
                        Console.ResetColor();
                        break;
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                        Console.WriteLine("Press the Enter key to continue.");
                        Console.ForegroundColor = ConsoleColor.White;
                        readResult = Console.ReadLine() ?? "";
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.ResetColor();
                        break;
                    default:
                        Console.ResetColor();
                        break;
                }

                Console.WriteLine("Press the Enter key to continue.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                readResult = Console.ReadLine() ?? "";
                Console.ResetColor();

            } while (_menuOption != "exit");
            Console.ResetColor();
        }
    }
}