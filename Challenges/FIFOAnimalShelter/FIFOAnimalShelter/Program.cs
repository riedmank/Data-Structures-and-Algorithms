using System;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FIFOAnimalShelter();
        }

        public static void FIFOAnimalShelter()
        {
            Animal dog1 = new Animal("dog");
            Animal dog2 = new Animal("dog");
            Animal dog3 = new Animal("dog");
            Animal cat1 = new Animal("cat");
            Animal cat2 = new Animal("cat");
            Animal cat3 = new Animal("cat");

            AnimalShelter Shelter = new AnimalShelter(dog1);

            Shelter.Enqueue(dog2);
            Shelter.Enqueue(dog3);
            Shelter.Enqueue(cat1);
            Shelter.Enqueue(cat2);
            Shelter.Enqueue(cat3);

            Console.WriteLine(dog1.AnimalType);
            Console.WriteLine(dog2.AnimalType);
            Console.WriteLine(dog3.AnimalType);
            Console.WriteLine(cat1.AnimalType);
            Console.WriteLine(cat2.AnimalType);
            Console.WriteLine(cat3.AnimalType);

            Console.WriteLine("dog" == "cat");

            Console.WriteLine("Dequeue animal at front: dog");

            Console.WriteLine(Shelter.Dequeue("dog").AnimalType);

            Console.WriteLine("===========================");

            Console.WriteLine("Dequeue animal not at front: cat");

            Console.WriteLine(Shelter.Dequeue("cat").AnimalType);

            Console.WriteLine("===========================");

            Console.WriteLine("Dequeue animal with bad target: zhevra");

            Console.WriteLine(Shelter.Dequeue("zhevra").AnimalType);
        }
    }
}
