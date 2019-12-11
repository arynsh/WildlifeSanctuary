using System;
using System.Collections.Generic;

namespace WildlifeSanctuary{

    public class Program
    {
        public static void Main()
        {
            Animal donkey1 = new Animal ("Don Quixote", "male", "Area 1", "donkey");   //name, gender, location, animal type
            Animal donkey2 = new Animal ("Don Nutella", "female", "Area 1", "donkey");
            Animal Emu1 = new Animal ("Waffle", "female", "Area 2", "emu");
            
            List<Animal> Animals = new List<Animal>() { donkey1, donkey2, Emu1 };

            Console.WriteLine("Enter type of animal: ");
            string stringAnimalType = Console.ReadLine();


            List<Animal> AnimalsMatchingSearch = new List<Animal>(0); 

            foreach (Animal individual in Animals)
            {
                if (individual.SearchByType(stringAnimalType))
                {
                    AnimalsMatchingSearch.Add(individual);
                }
            }

            foreach (Animal individual in AnimalsMatchingSearch)
            {
                Console.WriteLine("------------");
                Console.WriteLine(individual.GetName());
                Console.WriteLine(individual.GetGender());
                Console.WriteLine(individual.GetArea());
                Console.WriteLine(individual.GetTypeOfAnimal());
            }
        }
    }
}