namespace Nov1FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create the connection to the file
            //StreamWriter writer = new StreamWriter("test.txt");

            //// write to the file
            //writer.WriteLine("dsflkjsfdjkllkjsdf\n" +
            //    "hello world\n" +
            //    "the end.");

            //// close the connection
            //writer.Close();

            // create a variable to hold one line of data
            string line;
            
            // create a connection to the file
            StreamReader reader = new StreamReader("test.txt");

            // read its contents, line by line
            for(int i = 0; i < 4; i++)
            {
                line = reader.ReadLine();
                Console.WriteLine(line);
            }

            // close the connection
            reader.Close();
        }
    }
}