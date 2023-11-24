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
            _name = name;
            _isOmniscient = isOmniscient;
            _isOmnipotent = isOmnipotent;
            _numberOfFollowers = numberOfFollowers;
        }

        // getters
        public string GetName()
        {
            return _name;
        }
        // homework: create getter & setter method for all fields

        // setter method
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
    }
}
