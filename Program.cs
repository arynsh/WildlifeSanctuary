using System;
using System.Collections.Generic;
// using WildlifeSanctuary;

namespace WildlifeSanctuary
{ 
    public class Program
    {

        static void Main()
        { 
            Animal donkey1 = new Animal ("Don Quixote", "male", "Area 1", "donkey");   //name, gender, location, animal type
            Animal donkey2 = new Animal ("Don Nutella", "female", "Area 1", "donkey");
            Animal Emu1 = new Animal ("Waffle", "female", "Area 2", "emu");
            
            List<Animal> Animals = new List<Animal>() { donkey1, donkey2, Emu1 };

            Console.WriteLine("Would you like to search by animal type? ['Y' for yes, 'Enter' for no]");
            string answer1 = Console.ReadLine();
            if (answer1 == "Y" || answer1 == "y")
            {
                Animal.LookUpByTypeMethod(Animals);
            } else 
            {
                Console.WriteLine("Would you like to search by area? ['Y' for yes, 'Enter' for no]");
                string answer2 = Console.ReadLine();
                if (answer2 == "Y" || answer2 == "y")
                {
                    Animal.LookUpByAreaMethod(Animals);
                } 
                else
                {
                    Console.WriteLine("Would you like to exit? ['Y' for yes, 'Enter' for no]");
                    string answer3 = Console.ReadLine();
                    if (answer3 == "Y" || answer3 == "y")
                    {
                        Console.WriteLine("See you next time!!");
                    }
                    else{
                        Main();
                    }
                }
            }
        }


        // static void LookUpByTypeMethod()
        // { 
        //     Console.WriteLine("Enter type of animal: ");
        //     string stringAnimalType = Console.ReadLine();


        //     List<Animal> AnimalsMatchingSearch = new List<Animal>(0); 

        //     foreach (Animal individual in Animals)
        //     {
        //         if (individual.SearchByType(stringAnimalType))
        //         {
        //             AnimalsMatchingSearch.Add(individual);
        //         }
        //     }

        //     foreach (Animal individual in AnimalsMatchingSearch)
        //     {
        //         Console.WriteLine("------------");
        //         Console.WriteLine(individual.GetName());
        //         Console.WriteLine(individual.GetGender());
        //         Console.WriteLine(individual.GetArea());
        //         Console.WriteLine(individual.GetTypeOfAnimal());
        //     }
        // }

        // static void LookUpByAreaMethod()
        // { 
        //     Console.WriteLine("Enter area of animal: ['1' or '2']");
        //     string stringAnimalArea = Console.ReadLine();


        //     List<Animal> AnimalsMatchingSearch = new List<Animal>(0); 

        //     foreach (Animal individual in Animals)
        //     {
        //         if (individual.SearchByArea(stringAnimalArea))
        //         {
        //             AnimalsMatchingSearch.Add(individual);
        //         }
        //     }

        //     foreach (Animal individual in AnimalsMatchingSearch)
        //     {
        //         Console.WriteLine("------------");
        //         Console.WriteLine(individual.GetName());
        //         Console.WriteLine(individual.GetGender());
        //         Console.WriteLine(individual.GetArea());
        //         Console.WriteLine(individual.GetTypeOfAnimal());
        //     }
        // }
    
    }
  
  
}