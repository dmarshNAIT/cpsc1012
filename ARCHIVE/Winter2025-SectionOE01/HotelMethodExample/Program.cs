/*
 * Purpose:  A menu-based program that allows the user to 
             enter, view, and edit data related to hotel rooms.
 * Author:   D Marsh & OE01
 * Modified: March 6, 2025
 */
namespace HotelMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_RESERVATIONS = 100;
            string[] reservationNames = new string[MAX_RESERVATIONS];
            int[] numberOfGuests = new int[MAX_RESERVATIONS];
            int numberOfReservations = 0;
            string userAnswer;

            Console.WriteLine("Welcome!");

            // enter the program loop
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

        // other methods follow

        static void DisplayMenu()
        {
            Console.WriteLine("MAIN MENU\n" +
                "------------------\n" +
                "\t[v]iew reservations\n" +
                "\t[e]dit reservations\n" +
                "\t[a]dd reservation\n" +
                "\t[s]ave to file\n" +
                "\t[l]oad from file\n" +
                "\t[q]uit\n");
        }

        static int GiveMeNumber()
        {
            return 2;
        }

        #region
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
        #endregion

        static int AddReservation(string[] names, int[] numberOfGuests, int logicalSize)
        {
            if (logicalSize == names.Length || logicalSize == numberOfGuests.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, we are not accepting new reservations.");
                Console.ResetColor();
            }
            else
            {
                // ask the user for their name
                // save that into the array
                names[logicalSize] = GetUserString("What is the name on the reservation? ");

                // ask the user for their # of guests
                // save that into the array
                // validate that numberOfGuests is 10 or fewer
                while (numberOfGuests[logicalSize] < 1 || numberOfGuests[logicalSize] > 10)
                {
                    numberOfGuests[logicalSize] = GetUserInt("How many guests will be staying with us? ");
                    if (numberOfGuests[logicalSize] < 1 || numberOfGuests[logicalSize] > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You must have between 1 and 10 guests.");
                        Console.ResetColor();
                    }
                }

                // return the new # of elements
                logicalSize++;
            }
            return logicalSize;
        }

        static void ViewReservations(string[] names, int[] numberOfGuests, int logicalSize)
        {
            if ( logicalSize == 0)
            {
                Console.WriteLine("Sorry, there is no data to display.");
            }
            // check to ensure we have valid inputs (DEFENSIVE CODING)
            else if (logicalSize <= names.Length && logicalSize <= numberOfGuests.Length)
            {
                int columWidth = GetMaxLength(names, logicalSize) + 2;

                string outputMessage = "Res# Name".PadRight(columWidth) + "# of Guests\n";

                // iterate through the arrays
                // & display the raw values
                for (int i = 0; i < logicalSize; i++)
                {
                    outputMessage += $"{i+1:000}  " + names[i].PadRight(columWidth) + numberOfGuests[i] + "\n";
                }

                Console.WriteLine(outputMessage);
            }
            else
            {
                Console.WriteLine("There is an error in our data.");
            }
        }

        static int GetMaxLength(string[] names, int logicalSize)
        {
            int maxNumberOfCharacters = 0;

            for (int i = 0; i < logicalSize; i++)
            {
                // go through the array
                string currentName = names[i];
                // if the current name has more characters, set that to be the new maximum
                if (currentName.Length > maxNumberOfCharacters)
                {
                    maxNumberOfCharacters = currentName.Length;
                }
            }

            return maxNumberOfCharacters;
        }

        static void EditReservation(string[] names, int[] numberOfGuests, int logicalSize)
        {
            int reservationID,
                index;

            // let's show the user all the reservations
            ViewReservations(names, numberOfGuests, logicalSize);

            // ask the user to pick a number
            reservationID = GetUserInt("Please enter the reservation # you want to edit: ");
            while( reservationID <1 || reservationID > logicalSize )
            {
                reservationID = GetUserInt("Please enter a valid #: ");
            }
            index = reservationID - 1;

            // ask the user to re-enter the name, and save it to the array
            names[index] = GetUserString("Please enter the new name: ");
            // ask the user to re-enter the # of guests, and save that to the array
            numberOfGuests[index] = GetUserInt("Please enter the new # of guests: ");
            while((numberOfGuests[index] < 1 || numberOfGuests[index] > 10))
            {
                numberOfGuests[index] = GetUserInt("Sorry, you must have between 1 & 10 guests.\n" +
                    "Enter the new # of guests:  ");
            }

            // show a confirmation of the new values
            Console.WriteLine($"Reservation #{reservationID} for guest {names[index]} is confirmed for {numberOfGuests[index]} guests.");
        }

        static void SaveToFile(string[] names, int[] numberOfGuests, int logicalSize)
        {
            try
            {
                // create the StreamWriter object
                StreamWriter writer = new StreamWriter("../../../reservations.csv");
                // add the header
                writer.WriteLine("Reservation Name,Number Of Guests");

                // go through our arrays, and print the data line by line
                for (int i = 0; i < logicalSize; i++)
                {
                    writer.WriteLine(names[i] + "," + numberOfGuests[i]);
                }

                // close the connection
                writer.Close();
                Console.WriteLine("Successfully saved to file.");
            }
            catch
            {
                Console.WriteLine("Something went wrong saving the file.");
            }
        }

        static int LoadFromFile(string[] names, int[] numberOfGuests)
        {
            int index = 0;
            try
            {
                // create our StreamReader object
                using (StreamReader reader = new StreamReader("../../../reservations.csv"))
                {
                    reader.ReadLine(); // read in the header, and do nothing with it

                    // read the file line by line
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();

                        // for each line, we need to split apart the name & # of guests
                        string[] parts = line.Split(',');
                        string name = parts[0];
                        int number = int.Parse(parts[1]);

                        // then we will save each into the relevant array
                        names[index] = name;
                        numberOfGuests[index] = number;

                        index++;
                    }
                }
                Console.WriteLine($"Successfully loaded {index} records.");
            }
            catch
            {
                Console.WriteLine("Something went wrong reading from the file.");
            }
            return index; // return the # of guests successfully read from the file
        }

    }
}
// TODO: work in some math? perhaps cost per room, # of guests
// TODO: possible extra array for room type or status






