/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
*/
#pragma warning disable CS8600
#pragma warning disable CS8604
using System;

namespace GuessingGame
{
    public class Program
    {
        static void Main()
        {
            //Example code to help you get started
            //-----------------------------------------------------
            //Prompt user for a numeric input by calling this method
            ExampleMethod("Enter a number: ");
            /* Takes an input from the user and converts (parses) it to an integer.
             * Console.ReadLine() reads numbers as strings, so it must be converted. */
            String input = Console.ReadLine();
            //Convert the input from a string data type to an integer data type.
            int num = Convert.ToInt32(input);

            //You can combine the two lines above into the following:
            //int num = Convert.ToInt32(Console.ReadLine());

            //Double the number (num = num * 2)
            num *= 2;
            /* Gets a random number between 0 and 10
             * The minimum bound is inclusive and the upper bound is exclusive (which is why it is 11 instead of 10) */
            int rand = Random.Shared.Next(0, 11);

            Console.WriteLine("Your number doubled is " + num);
            Console.WriteLine("Random number generated: " + rand);
            //-----------------------------------------------------

            //TODO: Your code here (you can remove this comment)
        }

        //Ignore the static keyword for now
        //The void keyword is the method's return type (void = nothing is returned)
        static void ExampleMethod(String prompt)
        {
            Console.Write(prompt);
        }
    }
}