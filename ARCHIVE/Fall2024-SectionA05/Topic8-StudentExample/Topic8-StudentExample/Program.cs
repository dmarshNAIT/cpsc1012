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

            // create Billy
            Student billy = new Student("Billy", 19);
            Console.WriteLine("Billy's average mark is " + billy.GPA);

            // enroll Billy in classes
            billy.EnrollStudent(new Course("Shapes 101", "playground", 1, Math.PI));
            billy.EnrollStudent(new Course("Whistle Blowing", "Boeing HQ", 5, 4.5));
            billy.EnrollStudent(new Course("College", "The Nest", 5, 100));
            // give Billy marks
            billy.ApplyGrade("Shapes 101", 87);
            billy.ApplyGrade("Whistle Blowing", 99);
            billy.ApplyGrade("College", 49.9);
            // see Billy's GPA
            Console.WriteLine("Billy's average mark is " + billy.GPA);

            // let's see Billy's courses
            Console.WriteLine(billy.GetEnrolledCourses());

            // let's test the withdraw method
            Console.WriteLine( billy.Withdraw("College") );
            Console.WriteLine( billy.Withdraw("River surfing" ));

            Console.WriteLine(billy.GetEnrolledCourses());

            //billy.SaveTranscript("billy.csv");

            billy.LoadTranscript("billy.csv");
            Console.WriteLine("AFTER LOADING FILE:");
            Console.WriteLine(billy.GetEnrolledCourses());
        }


    }
}
