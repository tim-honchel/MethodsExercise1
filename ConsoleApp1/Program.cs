using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the following information in order to create a story:");

            Console.WriteLine();
            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Favorite Color:");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Favorite Animal:");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Favorite Band:");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(Story(name, favoriteColor, favoriteAnimal, favoriteBand));
           
        }

        public static string Story(string name, string color, string animal, string band)
        {
            string story = "Once upon a time, there was a " + name + ". " + name + " had a thing for " + color + " "+ animal +"s. One day when " + name + " was at a concert for " + band + ", a " + color + " " + animal + " appeared.";
            return story;

        }
    }
}
