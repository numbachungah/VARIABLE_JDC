using System;

namespace VARIABLE_JDC
{
    class Program
    {
        static void Main(string[] args)
        {
            // declares an integer to store a favorite number
            int favoriteNumber;
            // boolean initialized to false for jumping and running
            bool isJumping = false, isRunning = false;
            // declare random float
            float myFloat;
            // assign the favorite number to 6
            favoriteNumber = 6;
            // assigning my float to 54.65
            myFloat = 54.65f;
            // Initiallizing constant final grade
            const double finalGrade = 90.0;

            // prints all varibles to console
            Console.WriteLine("Favorite #: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}
