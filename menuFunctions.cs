namespace PetsData
{
    public class menuFunctions
    {
        public static void ListAnimals(List<Animal> ourAnimals, int maxPets)
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


        public static void AddNewPet(List<Animal> ourAnimals, int maxPets, string readResult)
        {

            string anotherPet = "y";
            int petCount = 0;
            foreach (Animal animal in ourAnimals)
            {
                if (animal.ID != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
                Console.ResetColor();
            }


            while (anotherPet == "y" && petCount < maxPets)
            {

                bool validEntry = false;
                Animal pet = new Animal();

                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry.");
                    Console.ForegroundColor = ConsoleColor.White;
                    readResult = Console.ReadLine() ?? "";
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    if (readResult != null)
                    {
                        pet.Species = readResult.ToLower();

                        if (pet.Species != "dog" && pet.Species != "cat")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }

                    }

                } while (validEntry == false);

                // pet.Species.Substring(0, 1) can be simplified to pet.Species[..1]
                pet.ID = pet.Species[..1] + (petCount + 1).ToString();

                do
                {
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    Console.ForegroundColor = ConsoleColor.White;
                    readResult = Console.ReadLine() ?? "";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (readResult != null)
                    {
                        string animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out int petAge);
                            pet.Age = petAge;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);


                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    Console.ForegroundColor = ConsoleColor.White;
                    readResult = Console.ReadLine() ?? "";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (readResult != null)
                    {
                        pet.Appearance = readResult.ToLower();
                        if (pet.Appearance == "")
                        {
                            pet.Appearance = "tbd";
                        }
                    }
                } while (pet.Appearance == "");


                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    Console.ForegroundColor = ConsoleColor.White;
                    readResult = Console.ReadLine() ?? "";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (readResult != null)
                    {
                        pet.Personality = readResult.ToLower();
                        if (pet.Personality == "")
                        {
                            pet.Personality = "tbd";
                        }
                    }
                } while (pet.Personality == "");



                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    Console.ForegroundColor = ConsoleColor.White;
                    readResult = Console.ReadLine() ?? "";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (readResult != null)
                    {
                        pet.Nickname = readResult.ToLower();
                        if (pet.Nickname == "")
                        {
                            pet.Nickname = "tbd";
                        }
                    }
                } while (pet.Nickname == "");

                // add the new pet to the array
                ourAnimals.Add(AnimalManagement.CreateAnimal(pet.Species, pet.ID, pet.Age, pet.Appearance ?? "not specified", pet.Personality ?? "not specified", pet.Nickname ?? "not specified"));


                // increment petCount
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // new pet entry
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        readResult = Console.ReadLine() ?? " ";
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                // readResult = Console.ReadLine();
                Console.ResetColor();
            }
        }
    }
}