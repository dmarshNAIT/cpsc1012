using System.Xml.Linq;

namespace VideoGameCharacterClassDemo
{
    internal class VideoGameCharacter
    {

        /*** CHARACTERISTICS ***/
        private string _name = "Unknown";
        private int _hp = 100;
        private string _armor = "None";
        private string _weapon = "Fist";
        private List<string> _armorInventory = new List<string>();
        // TODO: add armor to the list
        // TODO: view armor that we have
        // TODO: FUTURE challenge: perhaps instead of a list of strings, we have a list of Armor objects, having properties of "type of armor", "strength", "what it protects against..."

        // stamina
        // gender
        // armor/weapon
        // hunger
        // luck
        // mana
        // evasiveness

        /*** PROPERTIES ***/
        public string Armor
        {
            get { return _armor; }
            set
            {
                // we are only allowed to set Armor to a value that is ALREADY in the _armorInventory list
                if (_armorInventory.Contains(value))
                {
                    _armor = value;
                } else // not a valid option
                {
                    throw new Exception("NOOOO. You must select something from your inventory. :)");
                }
            }
        }


        /*** BEHAVIOUR ***/
        /*** CONSTRUCTORS ***/
        // "greedy" constructor (takes ALL the parameters it can)
        public VideoGameCharacter(string name, int hp, string armor, string weapon)
        {
            
            Name = name; // take advantage of the validation in your setter or property

            _hp = hp; // TODO: add validation
            _armor = armor; // TODO: add validation
            _weapon = weapon; // TODO: add validation
        }

        // no-argument constructor (our version of the default constructor)
        public VideoGameCharacter() { }

        /*** ACCESSOR METHODS ***/
        public string GetName() { return _name; }
        public int GetHP() { return _hp; }
        public string GetArmor() { return _armor; }
        public string GetWeapon() { return _weapon; }

        /*** MUTATOR METHODS ***/
        // name: name must be 2-10 characters long
        public void SetName(string name)
        {
            if (name.Trim().Length >= 2 && name.Trim().Length <= 10)
            {
                _name = name;
            }
            else
            {
                throw new Exception("The name must be 2-10 characters long.");
            }
        }

        // instead of creating GetName() and SetName(), another approach is to create a single property called Name
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Trim().Length >= 2 && value.Trim().Length <= 10)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("The name must be 2-10 characters long.");
                }
            }
        }


        // hp: this cannot be directly set to a new value
        // TODO: armor: this can change but it must be picked from a list of things they have
        // TODO: weapon: same idea as armor



        // attack?
        // dance?
        // signature attack?

        /*** OTHER METHODS ***/
        public void LootBattlefield()
        {
            // ask the user what they looted
            string loot = GetUserString("What did you get from the loot box? ");
            // add the item to the list
            _armorInventory.Add(loot);
        }

        /// <summary>
        /// A reusable method which prompts the user for input then returns their inputted string.
        /// </summary>
        /// <param name="question">A message to display to the user.</param>
        /// <returns>The user-inputted text.</returns>
        public static string GetUserString(string question)
        {
            string userResponse;
            // ask the question
            Console.Write(question);
            // get the answer
            userResponse = Console.ReadLine();
            // return the answer
            return userResponse;
        }

        /// <summary>
        /// A reusable method which prompts the user for input then returns their inputted double.
        /// </summary>
        /// <param name="question">A message to display to the user.</param>
        /// <returns>A user-entered double.</returns>
        public static double GetUserDouble(string question)
        {
            while (true)
            {
                // ask the user a question
                Console.Write(question);

                // read in their answer
                // try to parse it as a double
                try
                {
                    return double.Parse(Console.ReadLine());
                    // if that works, return it
                    // this is the only way to exit the method
                }
                catch  // otherwise, loop back & try again
                {
                    Console.WriteLine("Please enter a valid number. Try again.");
                }
            } // end of loop
        } // end of method

        /// <summary>
        /// A reusable method which prompts the user for input then returns their inputted int.
        /// </summary>
        /// <param name="question">A message to display to the user.</param>
        /// <returns>A user-entered int.</returns>
        public static int GetUserInt(string question)
        {
            while (true)
            {
                // ask the user a question
                Console.Write(question);

                // read in their answer
                // try to parse it as a int
                try
                {
                    return int.Parse(Console.ReadLine());
                    // if that works, return it
                    // this is the only way to exit the method
                }
                catch  // otherwise, loop back & try again
                {
                    Console.WriteLine("Please enter a valid number. Try again.");
                }
            } // end of loop
        } // end of method

        /// <summary>
        /// A reusable method which prompts the user for input then returns their inputted char.
        /// </summary>
        /// <param name="question">A message to display to the user.</param>
        /// <returns>A user-entered char.</returns>
        public static char GetUserChar(string question)
        {
            while (true)
            {
                // ask the user a question
                Console.Write(question);

                // read in their answer
                // try to parse it as a char
                try
                {
                    return char.Parse(Console.ReadLine());
                    // if that works, return it
                    // this is the only way to exit the method
                }
                catch  // otherwise, loop back & try again
                {
                    Console.WriteLine("Please enter a valid character. Try again.");
                }
            } // end of loop
        } // end of method

    }
}
