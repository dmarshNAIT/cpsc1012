namespace VideoGameCharacterClassDemo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // uncomment the next line if you want to run the test code
            //TestClass();

            RunProgram();
        }

        static void TestClass()
        {
            // instantiate an object, using the default values
            // the name of the object is "kirby"
            VideoGameCharacter kirby = new VideoGameCharacter();
            // we can create a character using our parameterized constructor
            VideoGameCharacter zelda = new VideoGameCharacter("Zelda", 100, "Light", "Fist");

            // test our accessor methods:
            Console.WriteLine($"The HP of {zelda.GetName()} is {zelda.GetHP()}.");
            Console.WriteLine($"The Armor of {zelda.GetName()} is {zelda.GetArmor()}.");
            Console.WriteLine($"The Weapon of {zelda.GetName()} is {zelda.GetWeapon()}.");

            // test our mutator:
            Console.WriteLine($"The object's name is {kirby.GetName()}");
            kirby.SetName("Kirby");
            Console.WriteLine($"The object's name is {kirby.GetName()}");
            try
            {
                kirby.SetName("X");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            Console.WriteLine($"The object's name is {kirby.GetName()}");

            // test our property:
            Console.WriteLine("The character's name is " + kirby.Name);
            kirby.Name = "Garlack th";
            Console.WriteLine("The character's name is " + kirby.Name);

            // test our armor functionality:
            // try to set the armor to an unallowed value
            try { kirby.Armor = "mud"; }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            // add armor to our inventory
            string loot = GetUserString("What did you get from the loot box? ");
            kirby.AddArmorToInventory(loot);
            // try to set the armor to a allowed value
            kirby.Armor = "Ivaldi's Curse";
            // try to set the armor to an unallowed value
            try { kirby.Armor = "mud"; }
            catch (Exception ex) { Console.WriteLine(ex.Message); }



        }

        static void RunProgram()
        {
            List<VideoGameCharacter> characters = new List<VideoGameCharacter>();
            char userChoice;

            // TODO: when the program starts, load in our characters from a file

            do
            {
                // show the menu
                DisplayMainMenu();

                // get the user's choice & force it to be lowercase:
                userChoice = Char.ToLower(GetUserChar("Please make your choice: "));

                // branch according to their choice
                switch (userChoice)
                {
                    case 'a':
                        AddCharacter(characters);
                        break;
                    case 'v':
                        // TODO:
                        break;
                    case 'e':
                        // TODO:
                        break;
                    case 's':
                        // TODO:
                        break;
                    case 'q':
                        // quit
                        // TODO: When the user quits, save the contents of the List to a file
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, that was not a valid choice. Try again.");
                        Console.ResetColor();
                        break;
                }

            } while (userChoice != 'q');

            Console.WriteLine("Thanks, goodbye!");
        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("MENU OPTIONS:\n" +
                "\t[a]dd new character\n" + // (TODO: create this method)
                "\t[v]iew characters\n" + // (TODO: create this method)
                "\t[e]dit character\n" + // TODO: create this method)
                "\t[s]wing sword at new character\n" + // TODO: come up with something fun!
                "\t[q]uit\n");
        }

        static void AddCharacter(List<VideoGameCharacter> characters)
        {
            // option 1:
            // let's create a default character
            VideoGameCharacter character = new VideoGameCharacter();
            bool isValidName = false;

            // then we will ask the user to provide each of the fields, and use setters to change them
            // first let's give the character a name
            do
            {
                try
                {
                    character.Name = GetUserString("What is your character's name? ");
                    isValidName = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while ( !isValidName );

            // option 2:
            // get all the inputs, then call the greedy constructor

            characters.Add(character);
        }

        /// <summary>
        /// A reusable method which prompts the user for input then returns their inputted string.
        /// </summary>
        /// <param name="question">A message to display to the user.</param>
        /// <returns>The user-inputted text.</returns>
        public static string GetUserString(string question)
        {
            string userResponse;
            // ask the question
            Console.Write(question);
            // get the answer
            userResponse = Console.ReadLine();
            // return the answer
            return userResponse;
        }

        /// <summary>
        /// A reusable method which prompts the user for input then returns their inputted double.
        /// </summary>
        /// <param name="question">A message to display to the user.</param>
        /// <returns>A user-entered double.</returns>
        public static double GetUserDouble(string question)
        {
            while (true)
            {
                // ask the user a question
                Console.Write(question);

                // read in their answer
                // try to parse it as a double
                try
                {
                    return double.Parse(Console.ReadLine());
                    // if that works, return it
                    // this is the only way to exit the method
                }
                catch  // otherwise, loop back & try again
                {
                    Console.WriteLine("Please enter a valid number. Try again.");
                }
            } // end of loop
        } // end of method

        /// <summary>
        /// A reusable method which prompts the user for input then returns their inputted int.
        /// </summary>
        /// <param name="question">A message to display to the user.</param>
        /// <returns>A user-entered int.</returns>
        public static int GetUserInt(string question)
        {
            while (true)
            {
                // ask the user a question
                Console.Write(question);

                // read in their answer
                // try to parse it as a int
                try
                {
                    return int.Parse(Console.ReadLine());
                    // if that works, return it
                    // this is the only way to exit the method
                }
                catch  // otherwise, loop back & try again
                {
                    Console.WriteLine("Please enter a valid number. Try again.");
                }
            } // end of loop
        } // end of method

        /// <summary>
        /// A reusable method which prompts the user for input then returns their inputted char.
        /// </summary>
        /// <param name="question">A message to display to the user.</param>
        /// <returns>A user-entered char.</returns>
        public static char GetUserChar(string question)
        {
            while (true)
            {
                // ask the user a question
                Console.Write(question);

                // read in their answer
                // try to parse it as a char
                try
                {
                    return char.Parse(Console.ReadLine());
                    // if that works, return it
                    // this is the only way to exit the method
                }
                catch  // otherwise, loop back & try again
                {
                    Console.WriteLine("Please enter a valid character. Try again.");
                }
            } // end of loop
        } // end of method
    }
}
