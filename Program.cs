using System;

namespace Variables_Pelky_Annalesa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares an integer to store a favorite number
            int favoriteNumber;
            // Booleans initialized to false for jumping and running
            bool isJumping = false, isRunning = false;
            // Declared random float variable
            float myFloat;
            // Assigning the favoriteNumber to 47
            favoriteNumber = 47;
            // Assigning myFloat to 54.65
            myFloat = 54.65f;
            // Initializing constant finalGrade to 90
            const double finalGrade = 90.0;

            // Prints all variables to console
            Console.WriteLine("Favorite #: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);

        }
    }
}
