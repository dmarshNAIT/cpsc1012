using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox
{
    class Car
    {
        // instance fields:
        private string Make;
        private string Model;
        private int Year;
        private string Colour = "red";
        private int NumDoors;

        // constructor:
        public Car()
        {

        } // default constructor

        public Car(string make, string model, int year, string colour)
        {
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
        } // end constructor method

        // other methods:
        public void Drive()
        {
            Console.WriteLine("Vroom vroom....");
        } // end Drive()

    } // end of Car class
} // end of my namespace
