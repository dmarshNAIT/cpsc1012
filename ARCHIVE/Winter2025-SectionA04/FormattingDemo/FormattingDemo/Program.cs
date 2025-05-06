namespace FormattingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentID = 12345678;
            double scholarship = 450.4444;

            // v1: let's just print out the raw #s
            Console.WriteLine("Original numbers:");
            Console.WriteLine($"Student ID: {studentID}");
            Console.WriteLine($"Scholarship: {scholarship}");
            Console.WriteLine();

            // v2: now let's add formatting to the values
            Console.WriteLine("Formatted numbers:");
            Console.WriteLine($"Student ID: {studentID:000-000-000}");
            Console.WriteLine($"Scholarship: {scholarship:c}");
            Console.WriteLine();

            // v3: let's line up the values
            Console.WriteLine("Right-Aligned numbers:");
            Console.WriteLine($"Student ID:  {studentID,12:000-000-000}");
            Console.WriteLine($"Scholarship: {scholarship,12:c}");
            Console.WriteLine();
            // the value 12 is saying "have this value take up 12 characters"
            // any extra space goes at the start

            // v4: line them up on the left
            Console.WriteLine("Left-Aligned numbers:");
            Console.WriteLine($"Student ID:  {studentID,-12:000-000-000}");
            Console.WriteLine($"Scholarship: {scholarship,-12:c}");
            Console.WriteLine();
        }
    }
}
