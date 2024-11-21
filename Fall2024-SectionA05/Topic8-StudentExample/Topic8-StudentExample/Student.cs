namespace Topic8_StudentExample
{
    internal class Student
    {
        // member variables
        // remember: think about visibility, initial values, static?

        private static int _identity; // the # of students

        private string _name = "John Doe";
        private int _studentNumber;
        private int _age = 18;
        private double _gpa; //default value for a double is 0

        //TODO: Parallel arrays: one for class
        //TODO: One for corresponding grade

        //TODO: a couple of constructors
        // no-arg constructor
        public Student() {
            _studentNumber = _identity + 1;
            _identity++;
        }
        // a constructor with lots of parameters

        //TODO: getters & setters
        // approach 1: creating getter & setter methods
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name) { 
            _name = name;
        }

        // approach 2: creating Properties
        /// <summary>
        /// Gets or sets the <c>_name</c> field.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        // TODO: add validation to all getters
        // TODO : add properties for all the relevant fields


        //LATER TODO: create some other methods to do things

    }
}
