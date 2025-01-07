namespace Nov1FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create the connection to our file
            StreamWriter writer = new StreamWriter("new.txt");
            //StreamWriter writer = new StreamWriter("../new.txt");
            // v2 shows an example of not using the default location, but one level up instead. 

            // write some content to that file
            writer.WriteLine("here is some text\n" +
                "fdslkjdfsjkldfs\n" +
                "the end.");

            // close the file
            writer.Close();

            string line;

            // create a reader object
            StreamReader reader = new StreamReader("new.txt");

            // read from our file & print out what we read
            for (int i = 0; i < 3; i++)
            {
                line = reader.ReadLine();
                Console.WriteLine(line);
            }

            // close the connection
            reader.Close();
        }
    }
}