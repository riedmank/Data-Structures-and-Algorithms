using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        public AnimalShelter(Animal front, Animal rear)
        {
            Front = front;
            Rear = rear;
        }

        public Animal Peek()
        {
            return Front;
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
    }
}
