using System;

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
   }
}