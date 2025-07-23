using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo_Dog
{
    internal class Dog
    {
        /**** characteristics ****/
        private string _name = "Unknown"; // initializing the member variable
        // microchip ID
        // breed
        // hair length
        // shed vs non-shed
        // tail
        // allergenic
        private string _size = "small"; // initializing the member variable
        // attitude
        // colour
        private int _age; // the default value for an int is 0
        // gender/sex
        // neuter/spay
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


    }
}
