
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
            

        }
    }
}
