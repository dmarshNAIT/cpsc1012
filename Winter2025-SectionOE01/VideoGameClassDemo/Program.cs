﻿namespace VideoGameClassDemo
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
            List<VideoGameCharacter> characters = new List<VideoGameCharacter>();
            string userAnswer;

            Console.WriteLine("Welcome!!!");
            if (VideoGameCharacter.LoadFromFile(characters))
                Console.WriteLine($"{characters.Count} characters were loaded from file.");
            else
                Console.WriteLine("Something went wrong reading the file.");
            
            do
            {
                // show the main menu
                DisplayMenu();

                // get the user's choice, and use that to branch 
                userAnswer = ReadUserString("Please enter choice: ").ToLower();

                switch (userAnswer)
                {
                    case "a":
                        AddCharacter(characters);
                        break;
                    case "e":
                        // TODO: edit a character
                        break;
                    case "r":
                        RemoveCharacter(characters);
                        break;
                    case "v":
                        ViewCharacters(characters);
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

            if (VideoGameCharacter.SaveToFile(characters))
                Console.WriteLine("Successfully saved characters to file.");
            else
                Console.WriteLine("Error saving characters. Sorry.");

            Console.WriteLine("Thanks! Goodbye.");


        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n*** MENU OPTIONS ***\n" +
                "V: View all Characters\n" +
                "A: Add new Character\n" +
                "E: Edit a Character\n" +
                "R: Remove a Character\n" +
                "Q: Quit\n");
        }

        static void AddCharacter(List<VideoGameCharacter> characters)
        {
            // option 1: we get all 3 fields from the user, and use those to create a new character

            // option 2: we create a default character, then use setters/properties to modify each field
            VideoGameCharacter newGuy = new VideoGameCharacter();
            bool isValidInput = false;

            while (isValidInput == false)
            {
                try
                {
                    string userAnswer = ReadUserString("What is the character's name? ");
                    newGuy.SetName(userAnswer);
                    isValidInput = true;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }

            // add Character to the List
            characters.Add(newGuy); // Add() is a C# method from the List class

        }

        static void ViewCharacters(List<VideoGameCharacter> characters)
        {
            Console.WriteLine("#   " + "NAME".PadRight(21) + "LVL RANK   HP");
            for (int i = 0; i < characters.Count; i++)
            {
                Console.WriteLine($"{i + 1:000} " + characters[i].ShowDetails());
            }

        }

        static void RemoveCharacter(List<VideoGameCharacter> characters)
        {
            int characterNum;
            string userAnswer;
            VideoGameCharacter character;

            // display the current characters
            ViewCharacters(characters);
            // ask the user to pick one
            characterNum = ReadUserInt("Enter the # of the character you wish to remove: ");

            while(characterNum < 1 || characterNum > characters.Count)
                characterNum = ReadUserInt("INVALID. Please enter a valid #: ");

            character = characters[characterNum - 1];

            // ask the user to confirm
            userAnswer = ReadUserString($"You have selected to delete {character.GetName()}.\n" +
                $"Enter Y to confirm, or any other key to cancel.").ToUpper();

            // if so, remove them
            if(userAnswer == "Y")
                characters.RemoveAt(characterNum - 1);
            else
                Console.WriteLine("Exiting back to Main Menu...");
        }

        static string ReadUserString(string question)
        {
            string userInput;

            // print the question
            Console.Write(question);

            // read the user's response
            userInput = Console.ReadLine();

            // return response
            return userInput;
        }

        static int ReadUserInt(string question)
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
