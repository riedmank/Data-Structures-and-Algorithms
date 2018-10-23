using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
        }

        /// <summary>
        /// Adds animal to the front of the Animal Shelter
        /// </summary>
        /// <param name="animal">Takes in an Animal</param>
        public void Enqueue(Animal animal)
        {
            Rear.Next = animal;
            Rear = animal;
        }

        /// <summary>
        /// Removes the front Animal from the Animal Shelter
        /// </summary>
        /// <returns>Returns an Animal object</returns>
        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Removes a specific Animal type from the Animal Shelter or the first Animal in line
        /// </summary>
        /// <param name="target">Animal to be removed</param>
        /// <returns>Returns an Animal from the Animal Shelter</returns>
        public Animal Dequeue(string target)
        {
            Animal result;
            if (Front.AnimalType == target)
            {
                return Dequeue();
            }
            else if (target != "cat" && target != "dog")
            {
                return Dequeue();
            }
            Animal temp = Front;
            while (target != Front.AnimalType)
            {
                Enqueue(Dequeue());
                if (temp == Front)
                {
                    return Dequeue();
                }
            }
            result = Dequeue();
            while (Front != temp)
            {
                Enqueue(Dequeue());
            }
            return result;
        }
    }
}
