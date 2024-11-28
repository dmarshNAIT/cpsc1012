namespace Topic8_BobTheBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // build some houses
            House defaultHouse = new House();
            House fancyHouse = new House(20, 4, 21, true);
            // order of my ints must match
            House fancyHouseV2 = new House(numberRooms: 20, numberFloors: 4, 21, true);
            // optionally, we can use named parameters to improve readability and hopefully reduce confusion

            // test my setter & getter methods
            fancyHouse.SetTemperature(25);
            Console.WriteLine("The temperature of my fancy house is " + fancyHouse.GetTemperature());

            // test my properties:
            fancyHouseV2.Temperature = 18;
            Console.WriteLine("The temperature of my other fancy house is " + fancyHouseV2.Temperature);

            List<House> houses = new List<House>();
            houses.Add(defaultHouse);
            houses.Add(fancyHouse);
            houses.Add(fancyHouseV2);

            string userChoice = "",
                fileName = "../../../houses.csv";

            do
            {
                Console.WriteLine("MAIN MENU\n" +
                    "\t[N]ew house\n" +
                    "\t[D]isplay house details\n" +
                    "\t[E]dit house\n" +
                    "\t[L]oad from file\n" +
                    "\t[S]ave to file\n" +
                    "\t[Q]uit\n");

                // don't worry about exception handling in THIS program for now
                Console.Write("Please enter your choice: ");
                userChoice = Console.ReadLine().ToUpper();

                switch (userChoice)
                {
                    case "N":
                        AddNewHouse(houses);
                        break;
                    case "D":
                        DisplayHouseDetails(houses);
                        break;
                    case "E":
                        Console.WriteLine("TODO: edit house");
                        break;
                    case "L":
                        Console.WriteLine("TODO: load file");
                        break;
                    case "S":
                        SaveToFile(fileName, houses);
                        break;
                    case "Q":
                        // user wants to quit, do nothing.
                        break;
                    default:
                        Console.WriteLine("Not an option. Try again.");
                        break;
                }

            } while (userChoice != "Q");


            Console.WriteLine("Have a nice day!");
        }

        static void AddNewHouse(List<House> list)
        {
            // create a house using the no-arg constructor
            House house = new House();
            bool isValid = false;

            // prompt the user for details & set each property
            do
            {
                try
                {
                    house.NumberRooms = GetValidInt("Enter # rooms: ");
                    isValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid entry. Please try again.");
                    Console.ResetColor();
                }
            } while (isValid == false);

            isValid = false;
            do
            {
                try
                {
                    house.NumberFloors = GetValidInt("Enter # floors: ");
                    isValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid entry. Please try again.");
                    Console.ResetColor();
                }
            } while (isValid == false);

            isValid = false;
            do
            {
                try
                {
                    house.Temperature = GetValidDouble("Enter temperature in C: ");
                    isValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid entry. Please try again.");
                    Console.ResetColor();
                }
            } while (isValid == false);

            isValid = false;
            do
            {
                try
                {
                    house.HasGarage = GetValidBool("House has garage? True/False: ");
                    isValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid entry. Please try again.");
                    Console.ResetColor();
                }
            } while (isValid == false);

            // add it to the list
            list.Add(house);
        }

        static void DisplayHouseDetails(List<House> list)
        {
            int counter = 1;

            // iterate through each house in the list
            foreach (House element in list)
            {
                string garageText = element.HasGarage ? "has" : "does not have";

                Console.WriteLine($"House #{counter++} has {element.NumberRooms} rooms, {element.NumberFloors} floors, is {element.Temperature} degrees, and {garageText} a garage.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static void SaveToFile(string fileName, List<House> list)
        {
            try
            {
                // create our StreamWriter object
                StreamWriter writer = new StreamWriter(fileName);

                // hardcode the header line
                writer.WriteLine("Number of Rooms\tNumber of floors\tTemperature\tGarage");

                // for each house:
                foreach (House element in list)
                {
                    writer.WriteLine(element.NumberRooms + "\t" +
                         element.NumberFloors + "\t" +
                         element.Temperature + "\t" +
                         element.HasGarage);
                }

                // close the stream
                writer.Close();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("File successfully saved.");
                Console.ResetColor();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error saving to file.");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Reads in a character from the Console.
        /// </summary>
        /// <returns>user-inputted character</returns>
        static char GetValidChar()
        {
            char userResponse = '\0'; // null character
            bool isValid = false;

            Console.Write("Please enter a character: ");
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    userResponse = char.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("That is not a valid character. Please try again: ");
                }
                finally // this runs no matter what
                {
                    Console.ResetColor(); // set the text colour back to default
                }
            } while (!isValid);

            return userResponse;
        } // end of method

        /// <summary>
        /// Reads in an int from the Console.
        /// </summary>
        /// <returns>an int</returns>
        static int GetValidInt(string message)
        {
            int userResponse = 0;
            bool isValid = false;

            Console.Write(message);
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    userResponse = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("That is not a valid number. Please try again: ");
                }
                finally // this runs no matter what
                {
                    Console.ResetColor(); // set the text colour back to default
                }
            } while (!isValid);

            return userResponse;
        } // end of method

        static double GetValidDouble(string message)
        {
            double userResponse = 0;
            bool isValid = false;

            Console.Write(message);
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    userResponse = double.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("That is not a valid number. Please try again: ");
                }
                finally // this runs no matter what
                {
                    Console.ResetColor(); // set the text colour back to default
                }
            } while (!isValid);

            return userResponse;
        } // end of method

        static bool GetValidBool(string message)
        {
            bool userResponse = false;
            bool isValid = false;

            Console.Write(message);
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    userResponse = bool.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Please enter true or false: ");
                }
                finally // this runs no matter what
                {
                    Console.ResetColor(); // set the text colour back to default
                }
            } while (!isValid);

            return userResponse;
        } // end of method

    }
}


