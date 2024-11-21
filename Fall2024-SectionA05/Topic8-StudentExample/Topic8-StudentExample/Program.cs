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

            Console.WriteLine();
        }
    }
}
