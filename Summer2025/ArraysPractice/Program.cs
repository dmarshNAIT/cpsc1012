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
            int logicalSize = 0; // the # of animals/elements 
            // STRETCH GOAL: modify this to have a 3rd array containing names
            bool isDead = false; // we have not yet been eaten by an animal
            int totalPets = 0;  // we are keeping track of the total pets across all species

            Console.WriteLine("Welcome to the Unsafe Zoo!");

            // start a loop
            do
            {
                string userChoice;
                int animalIndex;
                Random numberGenerator = new Random();

                // ask the user their choice
                Console.Write("Would you like to [1] pet an animal or [2] add a new animal? ");
                // save their answer
                userChoice = Console.ReadLine();

                // branch based on their answer
                switch (userChoice)
                {
                    case "1":
                        // display ALL the animals currently in the array
                        for (int i = 0; i < logicalSize; i++)
                        {
                            Console.WriteLine($"Animal ID {i + 1:00}: " + species[i]);   
                        }

                        // ask the user which one they want to pet
                        // ASSUME VALID INPUT FOR VERSION 1
                        Console.Write("Which animal did you pet? ");
                        // FUTURE TODO: add validation & exception handling
                        animalIndex = int.Parse(Console.ReadLine());

                        // update the countdown array
                        countdownUntilEaten[animalIndex] -= 1; //subtract 1 from that element

                        // if that pet has a countdown value of 0, let the person know they've been eaten
                        if(countdownUntilEaten[animalIndex] == 0)
                        {
                            Console.WriteLine("We regret to inform you that you have been eaten.");
                            isDead = true;
                        } else
                        {
                            Console.WriteLine("Now go wash your hands, you filthy animal.");
                        }

                        // update the totalPets value
                        totalPets += 1;

                        break;
                    case "2":
                        // get the name of the new animal
                        Console.Write("What species of animal would you like to add: ");
                        // add it to the animals array
                        species[logicalSize] = Console.ReadLine();
                        // STRETCH TODO: add validation e.g. can't be duplicate, has to be so many characters long, etc.

                        // initialize the matching element in the countdown array
                        countdownUntilEaten[logicalSize] = 10;
                        // STRETCH TODO: instead of always 10, initialize to a random # 1-10
                        //countdownUntilEaten[logicalSize] = numberGenerator.Next(1, 11);

                        logicalSize++;
                        Console.WriteLine("You have added a new animal.");
                        break;
                    default:
                        Console.WriteLine("That wasn't an option. Do better.");
                        break;
                }

            } while (isDead == false && totalPets < 10);
            // we loop as long as we have NOT been eaten
            // AND we haven't met the minimum pets

            // TODO: let the user if they have pet enough animals

            Console.WriteLine("Thanks for visiting our zoo.");

        } // TALK ABOUT SCOPE
    }
}
