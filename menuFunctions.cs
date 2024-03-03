namespace petsData
{
    public class menuFunctions
    {
        public static void listAnimals(List<Animal> ourAnimals, int maxPets)
        {
            foreach (Animal animal in ourAnimals)
            {
                // Access animal properties directly
                Console.WriteLine($"ID #: {animal.ID}");
                Console.WriteLine($"Species: {animal.Species}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"Nickname: {animal.Nickname}");
                Console.WriteLine($"Physical description: {animal.Appearance}");
                Console.WriteLine($"Personality: {animal.Personality}");
                
                Console.WriteLine();
            }
        }

        public static void ExitApp()
        {
            Console.WriteLine("You are now exiting the program");
            Environment.Exit(0);
        }
    }
}
