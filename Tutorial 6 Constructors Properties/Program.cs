// ----- Program.cs -----

using System;

namespace CSharpTutA.cs
{
    class Program
    {

        static void Main(string[] args)
        {
            Animal cat = new Animal();

            // Call the setter
            cat.SetName("Whiskers");

            // Set the property
            cat.Sound = "Meow";

            Console.WriteLine("The cat is named {0} and says {1}",
                cat.GetName(), cat.Sound);

            // Test auto generated getters and setters
            cat.Owner = "Derek";

            Console.WriteLine("{0} owner is {1}",
                cat.GetName(), cat.Owner);

            // Get the read-only id number
            Console.WriteLine("{0} shelter id is {1}",
                cat.GetName(), cat.idNum);

            // Test static property
            Console.WriteLine("# of Animals : {0}",
                Animal.NumOfAnimals);


            Console.ReadLine();

        }

    }

}