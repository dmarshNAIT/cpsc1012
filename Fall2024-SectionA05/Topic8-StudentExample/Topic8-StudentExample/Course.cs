//TODO: make sure that none of the fields can contain commas
// why? because it will break our CSV

namespace Topic8_StudentExample
{
    internal class Course
    {
        // member variables:
        private readonly string _courseName; // readonly so we cannot change it after the object is constructed
        private string _classroom;
        private byte _stressLevel; // 0 no stress - 5 max stress
        private double _credits = 3;

        // properties
        public string CourseName
        {
            get { return _courseName; }
            init { _courseName = value; }
        }

        public string Classroom
        {
            get { return _classroom; }
            set { _classroom = value; } //TODO: validate
        }

        public byte StressLevel
        {
            get { return _stressLevel; }
            set { _stressLevel = value; } //TODO: validate
        }

        public double Credits
        {
            get { return _credits; }
            init { _credits = value;  } // this means we can only set it in the constructor
        }

        // constructors
        // no-arg constructor
        public Course() { }
        // greedy constructor
        public Course(string courseName, string classroom, byte stressLevel, double credits) {
            CourseName = courseName;
            Classroom = classroom;
            StressLevel = stressLevel;
            Credits = credits;
        }
    }
}
