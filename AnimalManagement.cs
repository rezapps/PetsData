namespace petsData
{
    public static class AnimalManagement
    {

        public static void InitializeAnimals(List<Animal> ourPets, int maxPets)
        {
            ourPets.Add(CreateAnimal("d1", "dog", 2, "lola", "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.", "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses."));
            ourPets.Add(CreateAnimal("d2", "dog", 9, "loki", "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.", "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs."));
            ourPets.Add(CreateAnimal("c3", "cat", 1, "Puss", "small white female weighing about 8 pounds. litter box trained.", "friendly"));
            ourPets.Add(CreateAnimal("c4","cat", 0, "", "", ""));

            // Ensure the list has the desired capacity
            ourPets.Capacity = maxPets;
        }


        public static Animal CreateAnimal(string id, string species, int age, string nickname, string appearance, string personality)
        {
            return new Animal
            {
                ID = id,
                Species = species,
                Age = age,
                Nickname = nickname,
                Appearance = appearance,
                Personality = personality
            };
        }
    }
}
