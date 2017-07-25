using System;
using System.Collections.Generic;

namespace LambdaAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some Animal objects
            Animal animal1 = new Animal(() => { return "Dog"; }, () => { return "Vuf"; });
            Animal animal2 = new Animal(() => { return "Cat"; }, () => { return "Meow"; });
            Animal animal3 = new Animal(() => { return "Cat"; }, () => { return "Miav"; });
            Animal animal4 = new Animal(() => { return "Dog"; }, () => { return "Vov"; });

            // Create a List<Animal>, and insert the Animal 
            // objects into the List
            List<Animal> animals = new List<Animal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);

            // Print out all Animal objects (or those matching
            // your selection criterion).
            foreach (var animal in animals.FindAll(a => a.AnimalType == "Dog"))
            {
                Console.WriteLine(animal);
            }

            KeepConsoleWindowOpen();
        }


        private static void KeepConsoleWindowOpen()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to close application");
            Console.ReadKey();
        }
    }
}
