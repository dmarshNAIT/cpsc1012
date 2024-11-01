namespace Topic5_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../bob.txt";

            //// create our stream
            //StreamWriter writer = new StreamWriter(filePath);

            //// write to the file
            //writer.WriteLine("In Programmer World, Halloween is the one day a year when a Programmer can be malicious and no other Programmers can say anything else about it");
            //writer.WriteLine("Class, uh, finds a way.");
            //writer.WriteLine("Hi bob");

            //// (don't be evil): close the stream
            //writer.Close();




            // create our stream
            StreamReader reader = new StreamReader(filePath);

            // read from the file
            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                // print out to the console
                Console.WriteLine(line);
            }

            // close the stream
            reader.Close();

        }
    }
}
