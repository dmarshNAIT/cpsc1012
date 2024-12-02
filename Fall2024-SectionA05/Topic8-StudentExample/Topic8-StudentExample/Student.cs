namespace Topic8_StudentExample
{
    internal class Student
    {
        // member variables
        // remember: think about visibility, initial values, static?

        private static int _identity; // the # of students

        private string _name = "John Doe";
        private int _studentNumber = ++_identity;
        private byte _age = 18;
        private double _gpa; //default value for a double is 0

        private List<Course> _courses = new List<Course>();
        private List<double> _grades = new List<double>();

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
            get
            {
                double sum = 0, average;
                for (int i = 0; i < _grades.Count; i++)
                {
                    sum += _grades[i];
                }

                if (_grades.Count > 0)
                {
                    average = sum / _grades.Count;
                }
                else
                { average = 0; }

                return average;
            }
        }

        // no-arg constructor
        public Student()
        {
        }

        // a constructor with lots of parameters
        public Student(string name, byte age)
        {
            // set name
            Name = name;
            // using the property means I can re-use its validation and I don't need to repeat myself here

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

        public void EnrollStudent(Course newCourse)
        {
            // add that course to the student's course List
            _courses.Add(newCourse);
            // add an empty grade to the student's mark List
            _grades.Add(0);
        }

        // BONUS CONTENT:
        public void EnrollStudent(params Course[] courses)
        {
            foreach (Course course in courses)
            {
                _courses.Add(course);
                _grades.Add(0);
            }
        }

        public void ApplyGrade(string courseName, double grade)
        {
            // call FindCourse to get the index of the course
            int index = FindCourse(courseName);

            // set the same index of the grades List to the new grade
            if (index == -1)
            {
                throw new ArgumentOutOfRangeException();
            }

            _grades[index] = grade;
        }

        private int FindCourse(string courseName)
        {
            int foundLocation = -1;
            // iterate through each element in the List
            for (int index = 0; index < _courses.Count; index++)
            {
                // if an element has the same coursename ==> match!!
                if (_courses[index].CourseName == courseName)
                {
                    foundLocation = index;
                }
            }
            return foundLocation;
        }

        static public int GetNumberOfStudents()
        {
            return _identity;
            // realistically: this could just be another property.
        }

        public string GetEnrolledCourses()
        {
            string outputMessage = "";

            // for each course in the course list
            foreach (Course course in _courses)
            {
                outputMessage += course.CourseName + "\n";
            }

            return outputMessage;
        }

        public bool Withdraw(string courseName)
        {
            // get the location of the course in the list
            int courseIndex = FindCourse(courseName);
            bool successfulWithdraw = false;

            if (courseIndex != -1)
            {
                // remove the elements at that location in BOTH lists
                _courses.RemoveAt(courseIndex);
                _grades.RemoveAt(courseIndex);
                successfulWithdraw = true;
            }

            return successfulWithdraw;
        }

        //TODO:
        // CheckIfEnrolled: param of coursename, returns bool

    }
}
