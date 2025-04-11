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
            // optional TODO: sort

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
            while (!isValidName);

            // option 2:
            // get all the inputs, then call the greedy constructor

            characters.Add(character);
        }

        static void SaveToFile(List<VideoGameCharacter> list )
        {
            const string FILENAME = "characters.csv";

            try
            {
                // create a stream to the file
                StreamWriter writer = new StreamWriter("../../../" + FILENAME);
                // as written, if we use the name of an existing file, we will replace that file's contents.

                // save the header line:
                writer.WriteLine("NAME,HP,ARMOR,WEAPON");

                // go through the list, character by character, and add the info to the file
                for (int i = 0; i < list.Count; i++)
                {
                    VideoGameCharacter character = list[i];
                    writer.WriteLine(character.Name + ',' + 
                        character.GetHP() + ',' + 
                        character.Armor + ',' + 
                        character.GetWeapon());
                }

                // close the stream
                writer.Close();
                // if we don't, it's possible that other processes won't be able to access this file.

                Console.WriteLine("Successfully saved file.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong while saving to the file.");
            }

            /* file format: 

                DAY,HOURS 
                SUNDAY,7.0
                MONDAY,8.5
                TUESDAY,7.2
             */

        }

        static int LoadFromFile(string[] dayNames, double[] values)
        {
            int i = 0;
            // get the filename from the user
            string filename = GetUserString("Please enter a file name: ");
            // KNOWN GAP: the user could enter nonsense. We'll ignore this possibility for now.

            try
            {
                // create a stream Reader
                StreamReader reader = new StreamReader("../../../" + filename);
                reader.ReadLine(); // reading in the header

                while (reader.EndOfStream == false) // keep looping until the end of the file
                {
                    // read the file line by line
                    string line = reader.ReadLine();

                    // split up the parts
                    string[] parts = line.Split(','); // break up that line, using the comma to separate the values
                    string dayName = parts[0]; // the day name was the first "part" of the string we read
                    double hours = double.Parse(parts[1]); // the hours were the next "part" of the string we read

                    // save the day into the day array
                    dayNames[i] = dayName;

                    // save the hours value into the values array 
                    values[i] = hours;

                    i++; // increase the # of elements loaded
                }

                // close the stream
                reader.Close();

                Console.WriteLine($"Successfully loaded {i} records.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong loading this file.");
            }

            return i; // the # of elements
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
