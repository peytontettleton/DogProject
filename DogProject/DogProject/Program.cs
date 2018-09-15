using System;

namespace DogProject
{
    class Dog //https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/classes-and-objects
    {
        public enum Gender //https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/enums
        {
            Male, Female
        };

        public string name; //https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables
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


        public string getTag()
        {

            string hisOrher = getGender(gender).ToString();

            string heOrShe;

            if (hisOrher == "His")
            {
                heOrShe = "he";
            }
            else
            {
                heOrShe = "she";
            }
            return "If lost, call " + owner + ". " + hisOrher + " name is " + name + " and " + heOrShe + " is " + age + " year old.";
        }

        static void Main(string[] args)
        {
            Dog puppy =new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.getTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            Dog myDog =new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            myDog.bark(1); // output: Woof!
            Console.WriteLine(myDog.getTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
