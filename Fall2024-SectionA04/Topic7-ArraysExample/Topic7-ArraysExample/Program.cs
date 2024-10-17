/*
 * 
 * Purpose: play around with arrays!
 * 
 * 
 * 
 */ 
namespace Topic7_ArraysExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // create all variables
            int[] pokedex = new int[5];
            Random numberGenerator = new Random();
            string outputMessage = "The IDs of the Pokemon are ";
            int numberToFind = 0;
            bool isValid = false, 
                isFound = false;

            // load the array with random numbers & display
            for (int index = 0; index < pokedex.Length; index++)
            {
                pokedex[index] = numberGenerator.Next(1, 1026);
                // random number that's at least 1 and less than 1026
                // i.e. a number between 1 & 1025

                outputMessage += pokedex[index];
                // if it's the last element, add a period 
                if (index == pokedex.Length - 1)
                {
                    outputMessage += ".";
                }
                // otherwise, add a comma
                else
                {
                    outputMessage += ", ";
                }
            }

            /* CHALLENGE
             * 
             *  The IDs of the Pokemon are 123, 456, 1, 2, 999.
             * 
             * 
             */
            Console.WriteLine(outputMessage);

            // search the array for a user-inputted value

            do
            {
                // ask the user for a number
                Console.Write("What Pokemon ID are you searching for? ");
                // validate it's a valid number
                try
                {
                    numberToFind = int.Parse(Console.ReadLine());
                    if(numberToFind > 0 && numberToFind < 1025)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid: please enter a number between 1 & 1025.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid: please enter a number.");
                }
            } while ( !isValid  );

            // loop through the array
            for (int index = 0; index < pokedex.Length; index++)
            {
                // is this element the same as the number we are looking for?
                if (numberToFind == pokedex[index])
                {
                    isFound = true;
                }
            }
            // if we find the element, print "found!"
            // otherwise, print "not found"
            if (isFound)
            {
                Console.WriteLine("FOUND!");
            }
            else
            {
                Console.WriteLine("NOT FOUND!");
            }

            /*********** REVIEW *************/

            // when and how to use each type of loop
            // for: known # of iterations
            // do-while: loops at least once
            // while: any other situation

            // exceptions: what they are, how to deal with them
            // complex example

            // how to debug
        }
    }
}
