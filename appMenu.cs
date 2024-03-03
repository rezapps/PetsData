namespace petsData
{
    public class appMenu
    {
        public string? readResult;
        public string menuOption = "";


        // display menu options
        public void DisplayMenu(List<Animal> ourAnimals, int maxPets)
        {
            do
            {
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

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuOption = readResult.ToLower();
                }


                switch (menuOption)
                {
                    case "1":
                        // option 1 is display all pets
                        menuFunctions.listAnimals(ourAnimals, maxPets);
                        break;
                    case "exit":
                        menuFunctions.ExitApp();
                        break;
                    
                }
                Console.WriteLine("Press the Enter key to continue.");

                // pause code execution
                readResult = Console.ReadLine();

            } while (menuOption != "exit");
        }
    }
}