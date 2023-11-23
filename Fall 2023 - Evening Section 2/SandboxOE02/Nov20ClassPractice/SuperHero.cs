using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov20ClassPractice
{
    internal class SuperHero
    {
        // characteristics:
        private string _name;
        private string _superPower;
        private string _tragicBackstory;
        private int _yearsAsAvenger;
        private int _numKnownIdentity; // # of people who know their identity
        private bool _isRetired;
        private bool _usesWeapon;
        private bool _canFly;
        private bool _antiHero;

        // behaviour:
        /* constructor methods */
        public SuperHero()
        {
            _name = "Unknown";
            _superPower = "Unknown";
            _tragicBackstory = "Unknown";
        }

        public SuperHero(string name, string superPower, string tragicBackstory, int yearsAsAvenger, int numKnownIdentity, bool isRetired, bool usesWeapon, bool canFly, bool antiHero)
        {
            _name = name;
            _superPower = superPower;
            _tragicBackstory = tragicBackstory;
            _yearsAsAvenger = yearsAsAvenger;
            _numKnownIdentity = numKnownIdentity;
            _isRetired = isRetired;
            _usesWeapon = usesWeapon;
            _canFly = canFly;
            _antiHero = antiHero;
        }

        /* getter methods */
        public string GetName()
        {
            return _name;
        }
        public string GetSuperPower()
        {
            return _superPower;
        }
        public int GetYearsAsAvenger()
        {
            return _yearsAsAvenger;
        }
        // TO DO: create getter methods for all the other fields

        /* setter methods */
        public void SetIsRetired(bool isRetired)
        {
            _isRetired = isRetired;
        }
        public void SetUsesWeapon(bool usesWeapon)
        {
            _usesWeapon = usesWeapon;
        }
        public void SetCanFly(bool canFly)
        {
            _canFly = canFly;
        }
        public void SetYearsAsAvenger(int yearsAsAvenger)
        {
            if (yearsAsAvenger >= 0)
            {
                _yearsAsAvenger = yearsAsAvenger;

            }
            else
            {
                throw new Exception("Age cannot be negative.");
            }
        }
        // TO DO: create setter 

        /* other methods */
        // TO DO: create a method that displays all the super hero info
    }
}
