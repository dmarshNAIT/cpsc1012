namespace Topic8_Olympics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test our Record class
            // make sure I can construct things
            Record defaultRecord = new Record();

            // make sure I can get & set things
            Record record = new Record("Figure Skating", 1930, "Dana Marsh", 9, true);

            // Record badRecord = new Record("Figure Skating", 2030, "Dana Marsh", 9, true);

            List<Record> archive = new List<Record>();
            archive.Add(defaultRecord);
            archive.Add(record);

            //LoadFromFile();
            DisplayRecords(archive);

            // add a new record
            //DisplayRecords();

            //SaveToFile();


        }

        // LoadFromFile: List of records given as a param
        // it will read from a file
        // create a record for each line in the file
        // add each record to the given List

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
                    "\n" + "Score: ".PadLeft(15) + record.Score  );
            }
        }

        // SaveToFile: List of records given as a param
        // it will iterate through the list and save each to the file

        // ASPIRATIONAL TODO: Chart the records

    }
}
