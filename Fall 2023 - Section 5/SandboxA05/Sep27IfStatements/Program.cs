namespace Sep27IfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            string userResponse;
            int userFave, 
                weather;

            // welcome the user
            Console.WriteLine("Welcome to my program. " +
                "Please enter your favourite chocolate. " +
                "Enter 1 for milk, 2 for white, 3 for dark.");

            // prompt them for their favourite type of chocolate
            userResponse = Console.ReadLine();
            userFave = int.Parse(userResponse);

            // if they don't say "dark" then we heckle them
            if (userFave == 3)
            {
                Console.WriteLine("Yes, it's delicious.");
            }
            else
            {
                Console.WriteLine("I disagree.");
            } // end of else block

            // prompt the user to tell us the future
            Console.WriteLine("What will the weather be tomorrow? " +
                "1 = Sunny, 2 = Cloudy, 3 = Rainy");
            userResponse = Console.ReadLine();
            weather = int.Parse(userResponse);

            // if it's sunny, say "YAY!"
            if (weather == 1)
            {
                Console.WriteLine("yay!".ToUpper());
            }
            // if it's cloudy, we say "meh"
            else if (weather == 2)
            {
                Console.WriteLine("Meh.");
            }
            // if it's rainy, we say "oops"
            else if (weather == 3)
            {
                Console.WriteLine("oops.");
            }
            // or if they pick an invalid number:
            else
            {
                Console.WriteLine("That's not a weather type, you FOOL!");
            }






        } // end of Main()
    } // end of my class
} // end of program