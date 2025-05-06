namespace FileIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*** writing to a file ***/
            try
            {
                // create our Writer object
                StreamWriter writer = new StreamWriter("../../../TextyTestyDemoy.txt");
                // instead of the default location, we are going up THREE levels in the folder structure. this means we are creating it in the same folder as Program.cs
                // we are using a RELATIVE path (rather than an ABSOLUTE path)

                // write to the file
                writer.Write("I JUST WANNA WATCH THE CODE VERSION OF SUFFERING");
                writer.WriteLine("!!!!");

                // close the stream
                writer.Close();
            }
            catch
            {
                Console.WriteLine("Something went wrong saving the file.");
            }

            /*** reading FROM a file ***/
            try
            {
                // create our reader object
                StreamReader reader = new StreamReader("../../../animals.txt");

                // read from the file, line by line
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }

                // close the connection
                reader.Close();
            }
            catch
            {
                Console.WriteLine("Could not read from file.");
            }

            /***************** alternate approach ****************/
            // are you worried about forgetting to close the file?
            // the keyword USING will automatically close the stream for us
            try
            {
                // create our reader object
                using (StreamReader reader = new StreamReader("../../../animals.txt"))
                {
                    // read from the file, line by line
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Could not read from file.");
            }
        }
    }
}
