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

            string userChoice;
            do
            {
                // TODO before next class:
                // display menu
                // create a new object
                // get # of rooms
                // set # of rooms
                // get # of floors
                // set # of floors
                // get temp
                // set temp
                // see if there is a garage
                // change if there is a garage

                // don't worry about exception handling in THIS program for now

                // branch 


            } while (userChoice != "Q");


            Console.WriteLine();
        }
    }
}


