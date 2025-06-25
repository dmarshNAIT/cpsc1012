/*
 * Purpose: Practice creating and iterating through arrays.
 * Author:  Dana Marsh
 * Mod'd:   June 24, 2025
 */
namespace ArraysPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 50;

            // array of animal species
            string[] species = new string[ARRAY_SIZE];
            // array of animal pet counts
            int[] countdownUntilEaten = new int[ARRAY_SIZE];
            int logicalSize = 0;
            // STRETCH GOAL: modify this to have a 3rd array containing names
            bool isDead = false; // we have not yet been eaten by an animal
            int totalPets = 0;  // we are keeping track of the total pets across all species

            // start a loop
            do
            {
              
                string userChoice;
                // ask the user their choice
                Console.Write("Would you like to [1] pet an animal or [2] add a new animal? ");
                // save their answer
                userChoice = Console.ReadLine();

                // branch based on their answer
                switch (userChoice)
                {
                    case "1":
                        // TODO: let the user pet an animal
                        // TODO: remind the user to wash their hands
                        // TODO: check if they have pet that animal 10x. if so: they are eaten.
                        Console.WriteLine("You have chosen to pet an animal.");
                        break;
                    case "2":
                        // TODO: let the user add a new animal


                        // get the name of the new animal
                        Console.Write("What species of animal would you like to add: ");
                        // add it to the animals array
                        species[logicalSize] = Console.ReadLine();

                        // initialize the matching element in the countdown array

                        Console.WriteLine("You have added a new animal.");
                        break;
                    default:
                        Console.WriteLine("That wasn't an option. Do better.");
                        break;
                }

            } while (isDead == false && totalPets < 10);
            // we loop as long as we have NOT been eaten
            // AND we haven't met the minimum pets

            Console.WriteLine("Thanks for visiting our zoo.");

        } // TALK ABOUT SCOPE
    }
}
