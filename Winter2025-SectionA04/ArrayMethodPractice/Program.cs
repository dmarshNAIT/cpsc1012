using System;

namespace ArrayMethodPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = GetUserChoice("What is your favourite colour? ");

            string[] colours = { "pink", "yellow", "blue", "black", "green" };

            Console.WriteLine("Let's print out the first array: ");
            DisplayContents(colours);

            Console.WriteLine("Let's make a copy and print out its values:");
            string[] newArray = MakeACopy(colours);
            DisplayContents(newArray);

            Console.WriteLine("Now one last array:");
            // we are making another label pointing at the original array:
            string[] clone = colours;
            // colours & clone are both labels for the SAME array.

            Console.WriteLine("Let's modify the 2nd array.");
            newArray[0] = "red";

            Console.WriteLine("Now let's modify the original:");
            colours[0] = "indigo";
            // this affects colours & clone, because both are the SAME array!!
        }

        static string GetUserChoice(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        static string[] MakeACopy(string[] original)
        {
            // get the length of the original array:
            int originalArraySize = original.Length;
            // make sure the copied array has the same # of elements:
            string[] copy = new string[originalArraySize];

            for (int index = 0; index < original.Length; index++)
            {
                // get the value of the current element of the original array:
                string currentElement = original[index];
                // assign that value into the corresponding element of the new array:
                copy[index] = currentElement;
            }

            return copy;
        }

        static void DisplayContents(string[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine($"Element #{index + 1} has the value {array[index]}.");
            }
        }

        /// <summary>
        /// Allows user to enter values using the Console.
        /// </summary>
        /// <param name="array">an array that will be overwritten</param>
        /// <returns>the logical count</returns>
        static int EnterValues(string[] array)
        {
            int index = 0;

            for (; index < array.Length; index++)
            {
                array[index] = GetUserChoice("Please enter a colour you like: ");
            }

            return index;
        }

        // iterate through the elements
        // display them
        // search for something
        // enter new values
        // copy them somewhere else

        // access ONE particular element
        // edit the value

        // TODO: track the logical size

    }
}
