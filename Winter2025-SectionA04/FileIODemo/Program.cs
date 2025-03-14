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
        }
    }
}
