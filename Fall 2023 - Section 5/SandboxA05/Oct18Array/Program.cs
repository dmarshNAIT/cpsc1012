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
                Console.Write("Please enter a Pokemon: ");
                // save that to the current location
                myPokemon[index] = Console.ReadLine();
            }

            // display the values in the array
            // Your Pokemon are Pikachu, Charmander, Squirtle, ...

            // display a random Pokemon from the array
            // today's lucky Pokemon is .....

            // maybe we will search the array?
            // ask the user for a Pokemon, and we will tell them
            // if it is in the array already
            
        }
    }
}