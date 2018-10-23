using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class Animal
    {
        public string AnimalType { get; set; }

        public Animal(string value)
        {
            AnimalType = value;
        }
    }
}
