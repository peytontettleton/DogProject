
/using System;

namespace DogProject
{
    class Program
    {
        public enum Gender
        {
            Male, Female
        };

        public string name;
        public string owner;
        public int age;
        public Gender gender;

        public static string getGender(Gender gender)
        {
            if (gender == Gender.Male)
            {
                return "His";
            }
            return "Her";
        }

        // Keep the console window open in debug mode. Push key to exit.
        Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        static void Main(string[] args)
        {
            Dog puppy = Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.getTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            Dog myDog = Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            myDog.bark(1); // output: Woof!
            Console.WriteLine(myDog.getTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.

        }
    }
}
