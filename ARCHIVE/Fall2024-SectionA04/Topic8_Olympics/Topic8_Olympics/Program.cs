namespace Topic8_Olympics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test our Record class
            // make sure I can construct things
            //Record defaultRecord = new Record();

            // make sure I can get & set things
            //Record record = new Record("Figure Skating", 1930, "Dana Marsh", 9, true);

            //Record badRecord = new Record("Figure Skating", 2030, "Dana Marsh", 9, true);

            List<Record> archive = new List<Record>();
            //archive.Add(defaultRecord);
            //archive.Add(record);

            LoadFromFile(archive);
            DisplayRecords(archive);

            // add a new record
            archive.Add(new Record("Breakdancing", 2024, "Rachel Gunn", 0, true));
            Console.WriteLine("Adding new record....");

            DisplayRecords(archive);

            SaveToFile(archive);
        }

        // LoadFromFile: List of records given as a param
        // it will read from a file
        // create a record for each line in the file
        // add each record to the given List
        static void LoadFromFile(List<Record> danabase)
        {
            try
            {
                // create a connection to the file
                StreamReader reader = new StreamReader("olympians.txt");

                while (reader.EndOfStream == false)
                {
                    // read each line
                    string line = reader.ReadLine();

                    // save it as an object
                    string[] parts = line.Split('*');

                    // approach #1: using greedy constructor:
                    //Record record = new Record(
                    //    parts[0],
                    //    int.Parse(parts[1]),
                    //    parts[2],
                    //    float.Parse(parts[3]),
                    //    bool.Parse(parts[4])
                    //    );

                    // approach #2: using no-arg constructor & properties
                    Record record = new Record();
                    record.SportName = parts[0];
                    record.Year = int.Parse(parts[1]);
                    record.AthleteName = parts[2];
                    record.Score = float.Parse(parts[3]);
                    record.Active = bool.Parse(parts[4]);

                    // add that object to our List
                    danabase.Add(record);
                }

                // close the connection
                reader.Close();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong reading the file.");
                Console.ResetColor();
            }
        }

        // DisplayRecords: List of records given as a param
        // it will iterate through the list and display each record
        static void DisplayRecords(List<Record> danabase)
        {
            // for each element in the List
            foreach (Record record in danabase)
            {
                Console.WriteLine(
                    "\n" + "Sport: ".PadLeft(15) + record.SportName +
                    "\n" + "Year: ".PadLeft(15) + record.Year +
                    "\n" + "Athlete: ".PadLeft(15) + record.AthleteName +
                    "\n" + "Score: ".PadLeft(15) + record.Score);
            }
        }

        // SaveToFile: List of records given as a param
        // it will iterate through the list and save each to the file
        static void SaveToFile(List<Record> danabase)
        {
            try
            {
                // connect our program to a file
                StreamWriter writer = new StreamWriter("olympians.txt");

                for (int i = 0; i < danabase.Count; i++)
                {
                    Record currentRecord = danabase[i];

                    // write to that file
                    writer.WriteLine(currentRecord.SportName + "*" +
                        currentRecord.Year + "*" +
                        currentRecord.AthleteName + "*" +
                        currentRecord.Score + "*" +
                        currentRecord.Active);

                    // if we didn't create the currentRecord variable, we would access fields like this:
                    // danabase[i].SportName
                }

                // close that connection
                writer.Close();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong saving the file.");
                Console.ResetColor();
            }

            // exception handling

        }

        // ASPIRATIONAL TODO: Chart the records

    }
}
