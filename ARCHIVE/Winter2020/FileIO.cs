using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO; // this is required to create a StreamWriter or StreamReader object

namespace A04_ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is how we write to a file:
            //StreamWriter myWriter = new StreamWriter("test123.txt"); // writes to the default location
            StreamWriter myWriter = new StreamWriter("./../../../test123.txt");
            // writes to a location 3 levels up from the default location
            myWriter.WriteLine("hello, friends.");
            myWriter.Close();

            // this is how we read from a file:
            StreamReader myReader = new StreamReader("./../../../customers.txt");
            string customer1 = myReader.ReadLine();
            string customer2 = myReader.ReadLine();
            string customer3 = myReader.ReadLine();
            string customer4 = myReader.ReadLine();

            // instead of repeating code, we can use a for loop, and load the results into an array:
            string[] customers = new string[4];
            for (int counter = 0; counter < 4; counter++)
            {
                customers[counter] = myReader.ReadLine();
            } // end for

            // but that required us to know the length of the file in advance, which we don't always know. so, let's use a list instead:
            List<string> customerList = new List<string>();

            while (myReader.EndOfStream == false)
            {
                string customer = myReader.ReadLine();
                customerList.Add(customer);
            } // end while

            // if the file we're reading from is a .csv, we can use Split() to split the string into the individual values.
            StreamReader myCSVReader = new StreamReader("./../../../CustomerDetails.csv");
            string customerRawInfo = myCSVReader.ReadLine();
            string[] customerArrray = customerRawInfo.Split(',');
            // and then we can pass the individual values into an object,
            // or a 2d array, or parallel lists or arrays.
            Console.WriteLine($"Your customer's first name is {customerArrray[0]}.");

            // and we always end with:
            myReader.Close();

            Console.ReadLine();

        } // end method

    } // end class
} // end namespace
