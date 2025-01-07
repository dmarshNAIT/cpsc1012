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
            // it's not a great idea to use our fields directly here: 
            // instead all of these should use mutators with built-in validation.
            SetName(name);
            SetPower(superPower);
            _tragicBackstory = tragicBackstory; // not a great practice, see note above
            SetYearsAsAvenger( yearsAsAvenger);
            _numKnownIdentity = numKnownIdentity; // not a great practice, see note above
            SetIsRetired(isRetired);
            SetUsesWeapon(usesWeapon);
            SetCanFly(canFly);
            SetAntiHero(antiHero);
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
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetPower(string power)
        {
            _superPower = power;
        }
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

        /// <summary>
        /// Setter for the _yearsAsAvenger field.
        /// </summary>
        /// <param name="yearsAsAvenger">the # of years the superhero has been an Avenger</param>
        /// <exception cref="Exception">Years cannot be negative.</exception>
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
        public void SetAntiHero(bool antihero)
        {
            _antiHero = antihero;
        }
        // TO DO: create setter for other relevant fields

        /* other methods */
        // they turn into an anti hero after being a hero for a certain number of years
        public void TurnIntoAntiHero()
        {
            if(_yearsAsAvenger > 12)
            {
                _antiHero = true;

                // display their original backstory
                Console.WriteLine($"This hero's backstory is {_tragicBackstory}.");

                // add to it more tragedy
                _tragicBackstory += "\nToo much murder, work, and either too much or not enough Taylor Swift.";
            }
        }

        public void DisplayInfo()
        {
            const int COLUMN_WIDTH = 15;

            Console.WriteLine($"{"Name: ",COLUMN_WIDTH}{_name}\n" +
                $"{"Power: ",COLUMN_WIDTH}{_superPower}\n" + 
                $"{"Backstory: ",COLUMN_WIDTH}{_tragicBackstory}\n" +
                $"{"Years: ",COLUMN_WIDTH}{_yearsAsAvenger}\n" +
                $"{"Antihero: ",COLUMN_WIDTH}{_antiHero}\n");
            // TO DO: the rest
        }

        public void Edit()
        {
            DisplayInfo();

            char userChoice = char.ToUpper(ReturnUserChar("What would you like to edit?\n" +
                "\tN: Name\n" +
                "\tP: Power\n" +
                "\tH: Anti-Hero status\n" +
                "Your choice: "));

            switch (userChoice)
            {
                case 'N':
                    string newName = ReturnUserString("What is the new name? ");
                    SetName(newName);
                    break;
                case 'P':
                    string newPower = ReturnUserString("What is the new power? ");
                    SetPower(newPower);
                    break;
                case 'H':
                    bool isAntiHero = ReturnUserBool("Are they an anti-hero? True or false: ");
                    SetAntiHero(isAntiHero);
                    break;
                default:
                    Console.WriteLine("That was not valid.");
                    break;
            }

            // TO DO: the rest
        }

        private string ReturnUserString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private char ReturnUserChar(string prompt)
        {
            char userChar = '\0'; // null character
            bool isValid = false;

            do
            {
                // prompt the user
                Console.Write(prompt);

                // try to parse their answer 
                try
                {
                    userChar = char.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that's not valid.");
                }
            } while (!isValid);

            return userChar;  // if successful, return that value
        }

        private bool ReturnUserBool(string prompt)
        {
            bool userChar = false; // null character
            bool isValid = false;

            do
            {
                // prompt the user
                Console.Write(prompt);

                // try to parse their answer 
                try
                {
                    userChar = bool.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, that's not valid.");
                }
            } while (!isValid);

            return userChar;  // if successful, return that value
        }

    }
}
// Potential TO DO: make sure all superheros have a unique name?