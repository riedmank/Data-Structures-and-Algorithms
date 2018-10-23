using System;
using Xunit;
using static FIFOAnimalShelter.Program;
using FIFOAnimalShelter.Classes;

namespace AnimalShelterTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests if an Animal can be Dequeued from the front of the queue
        /// </summary>
        [Fact]
        public void CanGetAnimalFromFrontOfTheLine()
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

            Assert.Equal(dog1.AnimalType, Shelter.Dequeue("dog").AnimalType);
        }

        /// <summary>
        /// Tests if an Animal can be Dequeued that is not at the front of the line
        /// </summary>
        [Fact]
        public void CanGetAnimalFromNotFrontOfTheLine()
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

            Assert.Equal(cat1.AnimalType, Shelter.Dequeue("cat").AnimalType);
        }

        /// <summary>
        /// Tests that the line order is preserved after Dequeueing Animal not at the front
        /// </summary>
        [Fact]
        public void LineIsPreservedAfterDequeue()
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

            Shelter.Dequeue("cat");

            Assert.Equal(dog1, Shelter.Dequeue());
        }
        
        /// <summary>
        /// Tests is an Animal is returned when provided a bad target data
        /// </summary>
        [Fact]
        public void ReturnFirstAnimalIfTargetIsBad()
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

            Assert.Equal(dog1, Shelter.Dequeue("zhevra"));
        }

        /// <summary>
        /// Tests is we can Dequeue the last Cat, Enqueue another Cat, and Dequeue that Cat
        /// </summary>
        [Fact]
        public void CanDequeueEnqueueAndDequeueCorrectAnimal()
        {
            Animal dog1 = new Animal("dog");
            Animal dog2 = new Animal("dog");
            Animal dog3 = new Animal("dog");
            Animal dog4 = new Animal("dog");
            Animal cat1 = new Animal("cat");
            Animal cat2 = new Animal("cat");

            AnimalShelter Shelter = new AnimalShelter(dog1);

            Shelter.Enqueue(dog2);
            Shelter.Enqueue(dog3);
            Shelter.Enqueue(dog4);
            Shelter.Enqueue(cat1);

            Shelter.Dequeue("cat");

            Shelter.Enqueue(cat2);

            Assert.Equal(cat2, Shelter.Dequeue("cat"));
        }
        
        /// <summary>
        /// Tests to ensure an Animal is returned is there are no target Animals
        /// </summary>
        [Fact]
        public void CanReturnAnimalIfShelterDoesNotHaveAnimal()
        {
            Animal dog1 = new Animal("dog");
            Animal dog2 = new Animal("dog");
            Animal dog3 = new Animal("dog");
            Animal dog4 = new Animal("dog");
            Animal cat1 = new Animal("cat");
            Animal cat2 = new Animal("cat");

            AnimalShelter Shelter = new AnimalShelter(dog1);

            Shelter.Enqueue(dog2);
            Shelter.Enqueue(dog3);
            Shelter.Enqueue(dog4);
            Shelter.Enqueue(cat1);

            Shelter.Dequeue("cat");
            
            Assert.NotEqual(cat1, Shelter.Dequeue("cat"));
        }
    }
}
