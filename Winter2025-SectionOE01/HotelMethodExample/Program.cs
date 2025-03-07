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
                        // TODO: view reservations
                        break;
                    case "e":
                        // TODO: edit reservations
                        break;
                    case "a": // add reservation
                        numberOfReservations = AddReservation(reservationNames,
                            numberOfGuests, numberOfReservations);
                        break;
                    case "s":
                        // TODO: save reservations to a file
                        break;
                    case "l":
                        // TODO: load reservations from a file
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

        static int AddReservation(string[] names, int[] numberOfGuests, int count)
        {
            if (count == names.Length || count == numberOfGuests.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, we are not accepting new reservations.");
                Console.ResetColor();
            }
            else
            {
                // ask the user for their name
                // save that into the array
                names[count] = GetUserString("What is the name on the reservation? ");

                // ask the user for their # of guests
                // save that into the array
                // validate that numberOfGuests is 10 or fewer
                while (numberOfGuests[count] < 1 || numberOfGuests[count] > 10)
                {
                    numberOfGuests[count] = GetUserInt("How many guests will be staying with us? ");
                    if (numberOfGuests[count] < 1 || numberOfGuests[count] > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You must have between 1 and 10 guests.");
                        Console.ResetColor();
                    }
                }

                // return the new # of elements
                count++;
            }
            return count;
        }

    }
}
// TODO: work in some math? perhaps cost per room, # of guests
// TODO: possible extra array for room type or status



//// call a method with a return value:
//numberOfRooms = GiveMeNumber();



