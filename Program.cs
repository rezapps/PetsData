namespace petsData
{
    public class Program
    {
        // maximum number of pets
        static readonly int maxPets = 6;

        static void Main()
        {
            List<Animal> ourPets = new List<Animal>();

            // Call the initialization method
            AnimalManagement.InitializeAnimals(ourPets, maxPets);

            // Call the display menu method
            appMenu app = new appMenu();
            app.DisplayMenu(ourPets, maxPets);
        }
    }
}