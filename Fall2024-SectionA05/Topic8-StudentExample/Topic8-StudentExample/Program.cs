namespace Topic8_StudentExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create some new students
            Student maimee = new Student();
            Student moose = new Student();
            Student spruce = new Student();
            Student aioli = new Student();

            // test my getter & setter for name
            maimee.SetName("Maimee");
            Console.WriteLine("The student's name is " + maimee.GetName());

            // test my properties
            maimee.Name = "Maimee";
            Console.WriteLine("The student's name is " + maimee.Name);

            Console.WriteLine("Student number is " + maimee.StudentNumber);

            maimee.Age = 63;
            Console.WriteLine($"The student is {maimee.Age} years old.");

            Console.WriteLine("Their GPA is " + maimee.GPA);

            Console.WriteLine();

            // add all my students to a List
            List<Student> students = new List<Student>();
            students.Add( maimee );
            students.Add( moose );
            students.Add( spruce );
            students.Add( aioli );
            students.Add(maimee);

            // test my Enroll method
            Course course1 = new Course("River Surfing", "WA322", 4, 17.6);
            spruce.EnrollStudent(course1);

            spruce.EnrollStudent(new Course("Skydiving", "remote", 5, Math.PI));

            spruce.ApplyGrade("River Surfing", 100);
        }


    }
}
