namespace Topic5_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// create a stream
            //StreamWriter writer = new StreamWriter("../../../pumpkin.txt");

            //// write to the file
            //writer.WriteLine("Happy Hallowe'en!");
            //writer.WriteLine("Happy Diwali!");
            //writer.WriteLine("It's almost November.");

            //// close the stream
            //writer.Close();


            // create a stream
            StreamReader reader = new StreamReader("../../../pumpkin.txt");

            // read from the file
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }

            // close the stream
            reader.Close();
        }
    }
}
