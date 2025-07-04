/**
 * This program stores the prices of produce items sold at a market.
 * 
 * 0
 */ 
using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

namespace ArrayPractice_FarmersMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //One array contains the names of the produce e.g.zucchini
            //Another array contains the price per item in CAD
            string userChoice;

            // welcome
            Console.WriteLine("Hello! Welcome to Method Mart!");

            do
            {
                // TODO: call the method to display menu
                // TODO: get user's input & TRANSLATE TO LOWERCASE
                // TODO: call teh method to handle their choice
                // if they didn't choose to quit, keep looping
            } while ( userChoice != 'q'); // user choice isn't "q"

            // goodbye message

        }

        // TODO: method to Display Menu ***********
        // TODO: method to handle user's choice ***********
        // TODO: method to View Items
        // TODO: method to Add Items ***********
        // TODO: method to Edit Items
        // TODO: method to Delete Items
        // TODO: (FUTURE) ability to read and write from a file
    }
}

            //Future extensions:
            //Quantity in stock?
            //Weight / diameter ?