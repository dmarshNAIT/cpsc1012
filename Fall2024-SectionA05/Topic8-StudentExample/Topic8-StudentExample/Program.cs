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
        }
    }
}
