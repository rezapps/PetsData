namespace PetsData
{
    public class Program
    {
        // maximum number of pets
        static readonly int maxPets = 8;

        static void Main()
        {
            List<Animal> ourPets = new List<Animal>();

            // Call the initialization method
            AnimalManagement.InitializeAnimals(ourPets, maxPets);

            // Call the display menu method
            AppMenu app = new AppMenu();
            app.DisplayMenu(ourPets, maxPets);
        }
    }
}