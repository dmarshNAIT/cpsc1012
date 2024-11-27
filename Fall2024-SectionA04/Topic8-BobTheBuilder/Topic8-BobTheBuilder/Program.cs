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
            Console.WriteLine("The temperature of my other fancy house is "  + fancyHouseV2.Temperature);

            // TODO: add a list of houses
            List<House> houses = new List<House>();
            houses.Add(defaultHouse);
            houses.Add(fancyHouse);
            houses.Add(fancyHouseV2);

            string userChoice = "";
            do
            {

                Console.WriteLine("THE MENU");
              // TODO: make this into a proper CW
              // [N]ew house
              // [D]isplay house details (# rooms, # floors, etc)
              // [E]dit house (set # rooms, # floors, etc)
              // [L]oad from file
              // [S]ave to file
              // [Q]uit
  

                // don't worry about exception handling in THIS program for now

                // branch 
                switch (userChoice)
                {

                }


            } while (userChoice != "Q");


            Console.WriteLine();
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
        static int GetValidInt()
        {
            int userResponse = 0;
            bool isValid = false;

            Console.Write("Please enter a number: ");
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

    }
}


