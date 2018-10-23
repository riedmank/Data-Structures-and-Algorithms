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

        public void Enqueue(Animal animal)
        {
            Rear.Next = animal;
            Rear = animal;
        }

        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

        public Animal Dequeue(string target)
        {
            Animal result;
            if (Front == null)
            {
                return null;
            } 
            else if (Front.AnimalType == target)
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
