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
        public Deity(string name, bool isOmniscient, bool isOmnipotent, int numberOfFollowers) { 
            _name = name;
            _isOmniscient = isOmniscient;
            _isOmnipotent = isOmnipotent;
            _numberOfFollowers = numberOfFollowers;
        }

        // optional homework: create getter & setter method for all fields

        // Smite();
        // Inspire();
    }
}
