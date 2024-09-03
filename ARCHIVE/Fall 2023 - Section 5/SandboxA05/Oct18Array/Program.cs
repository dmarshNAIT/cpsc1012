namespace Oct18Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 10;

            // create an empty array that will contain Pokemon
            string[] myPokemon = new string[ARRAY_SIZE];

            // load the array with values
            for (int index = 0; index < myPokemon.Length; index++)
            {
                // ask them for a Pokemon
                Console.Write("Please enter a Pokemon: "); // TO DO: add the # of Pokemon
                // save that to the current location
                myPokemon[index] = Console.ReadLine();
            }

            // display the values in the array
            // Your Pokemon are Pikachu, Charmander, Squirtle, ...
            string outputMessage = "\nYour Pokemon are ";

            for (int index = 0; index < myPokemon.Length; index++)
            {
                outputMessage += myPokemon[index]; // add the Pokemon name to our string

                if (index < myPokemon.Length - 1) // not the last Pokemon
                    outputMessage = outputMessage + ", ";
                else  // the last Pokemon
                    outputMessage = outputMessage + ".";
            }

            Console.Write(outputMessage);

            // display a random Pokemon from the array
            // today's lucky Pokemon is .....
            // first we will generate a random # between 0 and 9
            Random numberGenerator = new Random();
            int randomNumber = numberGenerator.Next(myPokemon.Length);
            // this is the same as:
            //int randomNumber = numberGenerator.Next(0, myPokemon.Length);

            // then, we will print out the element at that index
            Console.WriteLine("\nToday's lucky Pokemon is " + myPokemon[randomNumber] + "." +
                    "\nThanks for playing! Goodbye.");

            // maybe we will search the array?
            // ask the user for a Pokemon, and we will tell them
            // if it is in the array already

        }
    }
}