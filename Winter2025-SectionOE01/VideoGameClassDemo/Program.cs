namespace VideoGameClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if I want to test the class, uncomment the following line
            //TestOurClass();

            // if I want to run the full program, uncomment the following line
            RunProgram();
        }

        static void TestOurClass()
        {

            VideoGameCharacter letmesoloher = new VideoGameCharacter();
            // ^ this line will only work if we have a default constructor
            // (which means we didn't create ANY constructors so the compiler made one automatically), or
            // if we create a no-argument constructor

            VideoGameCharacter mario = new VideoGameCharacter("Mario", 1, 85);

            // let's test our accessor methods:
            Console.WriteLine($"The name of the character is {mario.GetName()}.");
            Console.WriteLine($"The level of the character is {mario.GetLevel()}.");
            Console.WriteLine($"The HP of the character is {mario.GetHP()}.");

            // let's test our mutator methods:
            mario.SetLevel(5);
            mario.SetHP(150);
            Console.WriteLine($"The level of the character is {mario.GetLevel()}.");
            Console.WriteLine($"The HP of the character is {mario.GetHP()}.");

            // now let's test our propery
            Console.WriteLine($"The HP of the character is {letmesoloher.HP}.");
            letmesoloher.HP = 200;
            Console.WriteLine($"The HP of the character is {letmesoloher.HP}.");

            // let's create a list of characters
            List<VideoGameCharacter> characters = new List<VideoGameCharacter>();
            characters.Add(letmesoloher);
            characters.Add(mario);

            // let's level up Mario & check his rank
            Console.WriteLine("Mario's rank was originally " + mario.CharacterRank);
            mario.SetLevel(42);
            Console.WriteLine("Mario's rank is now " + mario.CharacterRank);


            // let's try creating something impossible
            try
            {
                VideoGameCharacter bob = new VideoGameCharacter("Bob", 1000, 10000);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void RunProgram()
        {
            // Load from file

            // looping menu
            // Add a new Character
            // View all Characters
            // Quit

            // save to file

            do
            {
                // show the main menu
                DisplayMenu();

                // get the user's choice, and use that to branch 
                userAnswer = GetUserString("Please enter choice: ").ToLower();

                switch (userAnswer)
                {
                    case "v":
                        ViewReservations(reservationNames, numberOfGuests, numberOfReservations);
                        break;
                    case "e":
                        EditReservation(reservationNames, numberOfGuests, numberOfReservations);
                        break;
                    case "a": // add reservation
                        numberOfReservations = AddReservation(reservationNames,
                            numberOfGuests, numberOfReservations);
                        break;
                    case "s":
                        SaveToFile(reservationNames, numberOfGuests, numberOfReservations);
                        break;
                    case "l":
                        numberOfReservations = LoadFromFile(reservationNames, numberOfGuests);
                        break;
                    case "q":
                        // quit
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, that's not an option. Try again.");
                        Console.ResetColor();
                        break;
                }
            }
            while (userAnswer != "q");
            // end loop

            Console.WriteLine("Thanks! Goodbye.");


        }

                static string GetUserString(string question)
        {
            string userInput;

            // print the question
            Console.Write(question);

            // read the user's response
            userInput = Console.ReadLine();

            // return response
            return userInput;
        }

        static int GetUserInt(string question)
        {
            while (true)
            {
                // ask the user for an int
                Console.Write(question);
                try
                {
                    // read in their response
                    // try to parse it
                    // if successful, return the value
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    // otherwise, loop back & try again
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number without decimals.");
                    Console.ResetColor();
                }
            }
        }
    }
}
