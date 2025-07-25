using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassDemo_Dog
{
    internal class Dog
    {
        /**** CHARACTERISTICS ****/
        // static means this field is shared across all instances of the class
        private static double _version = 1.0;
        //private static int _numberOfDogs = 1;
        private static bool _isDog = true;

        private string _name = "Unknown"; // initializing the member variable
        // microchip ID
        private string _breed = "Unknown";
        // hair length
        // shed vs non-shed
        // tail
        // allergenic
        private string _size = "small"; // initializing the member variable
        // attitude
        // colour
        private int _age; // the default value for an int is 0
        // gender/sex
        private bool _fixed; // neuter/spay status
        // indoor/outdoor
        // how smart they are

        /*** CONSTRUCTORS ***/
        // no-argument constructor
        public Dog() { }

        // parameterized constructor
        public Dog(string name, string size, int age)
        {
            _name = name;
            _size = size;
            _age = age;
        }

        public Dog(string name, string size)
        {
            _name = name;
            _size = size;
        }

        /*** ACCESSOR ***/
        public string GetName()
        {
            return _name;
        }

        /*** MUTATOR ***/
        public void SetName(string name)
        {
            // if the name is too short or too long, throw an Exception
            // otherwise, set the name to the provided value
            name = name.Trim(); // gets rid of leading or trailing whitespace

            if (name.Length <= 0 || name.Length > 21)
            {
                throw new Exception("Dog name must be between 1 & 21 characters in length.");
                // alternatively, we could have created an ArgumentException
            }
            else
            {
                _name = name;
            }
        }

        /*** PROPERTIES ***/
        // normally we don't do BOTH accessor/mutator AND a property, but here we will in order to see the difference in syntax
        public string Name
        {
            get { return _name; }
            set {
                if (value.Trim().Length <= 0 || value.Trim().Length > 21)
                {
                    throw new Exception("Dog name must be between 1 & 21 characters in length.");
                    // alternatively, we could have created an ArgumentException
                }
                else
                {
                    _name = value.Trim();
                }
            }

        }

        public string Size { 
            get { return _size; }
            set
            {
                // validate that it's a valid size
                // if so, we use it
                // if not, we throw an exception

                switch(value.Trim().ToLower())
                {
                    case "small":
                    case "medium":
                    case "large":
                    case "giant":
                        _size = value.Trim().ToLower();
                        break;
                    default:
                        throw new Exception("Size must be small, medium, large, or giant.");
                }
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                // validate that it's a valid age (non-negative values only)
                // if so, assign that value to the field
                // if not, raise error

                if (value < 0)
                    throw new Exception("Age must be 0 or greater.");
                else
                    _age = value;
            }

    }
}
