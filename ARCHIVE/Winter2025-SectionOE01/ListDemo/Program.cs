namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // let's create a List of sports
            List<string> sports = new List<string>();

            // add some records
            sports.Add("tennis");
            sports.Add("hockey");
            sports.Add("soccer");
            sports.Add("football");
            sports.Add("cricket");
            sports.Add("badminton");
            sports.Add("lawn bowling");
            sports.Add("baseball");
            sports.Add("basketball");

            // check the Capacity & Count
            Console.WriteLine("The count is: " + sports.Count);
            Console.WriteLine("The capacity is: " + sports.Capacity);

            // edit, remove, and insert records
            sports.Insert(0, "lawn bowling");
            sports[0] = "bocce";
            sports.Remove("badminton");

            // making a list of lists
            List<string> sportsBalls = new List<string>();
            sportsBalls.Add("basketball");
            sportsBalls.Add("jack");
            sportsBalls.Add("puck");

            List<List<string>> listOfLists = new List<List<string>>();
            listOfLists.Add(sports);
            listOfLists.Add(sportsBalls);

            // manually modify the count
            listOfLists.Capacity = 100;
            //listOfLists.Capacity = 1;
            listOfLists.TrimExcess();

            // accessing an element in a list in a list
            Console.WriteLine("The first element in the first list:");
            Console.WriteLine(listOfLists[0][0]);
        }
    }
}
