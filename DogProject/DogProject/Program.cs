using System;

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
        public Dog(string name1, string owner1, int age1, Gender gender1)
        {
            name = name1;
            owner = owner1;
            age = age1;
            gender = gender1;
        }

        public void bark(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("Woof!");

            }
            Console.WriteLine();
        }



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
