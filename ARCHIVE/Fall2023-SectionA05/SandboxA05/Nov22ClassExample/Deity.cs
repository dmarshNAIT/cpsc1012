namespace Nov22ClassExample
{
    internal class Deity
    {
        // fields
        private string _name = "Unknown";
        private bool _isOmniscient; // all-knowing
        private bool _isOmnipotent; // all-powerful
        private int _numberOfFollowers = 1;

        // methods
        // no-argument constructor
        public Deity() { }

        // parameterized constructor
        public Deity(string name, bool isOmniscient, bool isOmnipotent, int numberOfFollowers)
        {
            // it's not a good practice to set our fields directly:
            // a better implementation would use the mutators for all of these, as they have built-in validation.
            SetName(name);
            _isOmniscient = isOmniscient; // not a good practice - see note above
            _isOmnipotent = isOmnipotent; // not a good practice - see note above
            SetNumberOfFollowers(numberOfFollowers);
        }

        // getters
        public string GetName()
        {
            return _name;
        }
        // homework: create getter & setter method for all fields

        // setter method
        /// <summary>
        /// Sets the _name field.
        /// </summary>
        /// <param name="name">the new name of the Deity</param>
        public void SetName(string name)
        {
            _name = name;
        }

        public void SetNumberOfFollowers(int numberOfFollowers)
        {
            // if number Of Followers is negative: that's not allowed
            if (numberOfFollowers < 0)
            {
                throw new Exception("# of followers cannot be negative.");
            }
            // otherwise, we update the field
            else
            {
                _numberOfFollowers = numberOfFollowers;
            }
        }

        // Smite();
        public string Inspire()
        {
            // increase the number of followers by 12%
            _numberOfFollowers = (int)(_numberOfFollowers * 1.12);
            
            // send back an inspirational message
            return "Lionel Ritchie believes in you.";
        }

        public string DisplayInfo()
        {
            const int COLUMN_WIDTH = 13;

            return $"{"Name:",COLUMN_WIDTH} {_name}\n" +
                $"{"Omniscient?", COLUMN_WIDTH} {(_isOmniscient ? "yes" : "no")}\n" +
                $"{"Omnipotent?",COLUMN_WIDTH} {(_isOmnipotent ? "yes" : "no")}\n" +
                $"{"# Followers:", COLUMN_WIDTH} {_numberOfFollowers}";
        }
    }
}
