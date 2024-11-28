namespace Topic8_StudentExample
{
    internal class Student
    {
        // member variables
        // remember: think about visibility, initial values, static?

        private static int _identity; // the # of students

        private string _name = "John Doe";
        private int _studentNumber;
        private byte _age = 18;
        private double _gpa; //default value for a double is 0
        private List<Course> _courses = new List<Course>();
        private List<double> _grades = new List<double>();

        // no-arg constructor
        public Student()
        {
            _studentNumber = _identity + 1;
            _identity++;
        }
        // a constructor with lots of parameters
        public Student(string name, byte age)
        {
            // set name
            Name = name;
            // using the property means I can re-use its validation and I don't need to repeat myself here

            _studentNumber = _identity + 1;
            _identity++; //TODO later: un-duplicate

            // set age
            this.Age = age; // "this" is optional
            // "this" refers to the current object
        }

         // approach 1: creating getter & setter methods
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            if (name.Length > 0 && name.Length <= 100)
            {
                _name = name;
            }
            else
            {
                throw new Exception("Name must be 0-100 characters.");
            }
        }

        // approach 2: creating Properties
        /// <summary>
        /// Gets or sets the <c>_name</c> field.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 0 && value.Length <= 100)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Name must be 0-100 characters.");
                }
            }
        }

        public int StudentNumber
        {
            get { return _studentNumber; }
        }

        public byte Age
        {
            get { return _age; }
            set
            {
                if (value >= 16 && value <= 120)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Age must be between 16 and 120.");
                    // can use a more specific Exception class e.g. ArgumentOutOfRangeException
                }
            }
        }

        public double GPA
        {
            get { return _gpa; }
            // TODO: implement calculation
        }

        public void EnrollStudent(Course newCourse)
        {
            // add that course to the student's course List
            _courses.Add(newCourse);
            // add an empty grade to the student's mark List
            _grades.Add(0);
        }

        // BONUS CONTENT:
        public void EnrollStudent( params Course[] courses)
        {
            foreach (Course course in courses)
            {
                _courses.Add(course);
                _grades.Add(0);
            }
        }

        //TODO:
        // DisplayEnrolledCourses: no params
        // Withdraw: course
        // CheckIfEnrolled: provide a course name, get a bool
        // Grade: apply a mark for a specific course


    }
}


// TODO: clean up the order of things