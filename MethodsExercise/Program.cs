using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------Exercise 1
            //Name: Christian
            //Favorite Color: Red
            //Favorite Animal: Wolf
            //Favorite Band: The Cure
            //Favorite Song: Fascination Street

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. - What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! - What is your favorite animal?");
            var animal = Console.ReadLine();


           Console.WriteLine($"Great! - Now, what is your favorite band?");
            var band = Console.ReadLine();


            Console.WriteLine($"I love {band}. - My favorite song is fascination street!");
            var song = Console.ReadLine();


        }
    }
}
