using System;
using System.Collections.Generic;

namespace WildlifeSanctuary {
   
   class Animal 
   {
       private string _name;
       private string _gender;
       private string _area;
       private string _typeOfAnimal;

       public Animal(string name, string gender, string area, string typeOfAnimal)
       {
           _name = name;
           _gender = gender;
           _area = area;
           _typeOfAnimal = typeOfAnimal;
       }

        public string GetName()
        {
            return _name;
        }
       public string GetGender()
       {
           return _gender;
       }

       public string GetArea()
       {
           return _area;
       }
       public string GetTypeOfAnimal()
       {
           return _typeOfAnimal;
       }

       public bool SearchByType(string stringAnimalType)
       {
           return (_typeOfAnimal == stringAnimalType);
       }

        public bool SearchByArea(string stringAnimalArea)
        {
            return (_area == stringAnimalArea);
        }

         public static void LookUpByTypeMethod(List<Animal> Animals)
        { 
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

        public static void LookUpByAreaMethod(List<Animal> Animals)
        { 
            Console.WriteLine("Enter area of animal: ['Area 1' or 'Area 2']");
            string stringAnimalArea = Console.ReadLine();


            List<Animal> AnimalsMatchingSearch = new List<Animal>(0); 

            foreach (Animal individual in Animals)
            {
                if (individual.SearchByArea(stringAnimalArea))
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