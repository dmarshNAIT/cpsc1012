namespace List_Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> movies = new List<string>();

            movies.Add("Zoolander");
            movies.Add("Lucky Number Slevin");
            movies.Add("Frozen");
            movies.Add("Zoolander II");
            movies.Add("Oppenheimer");
            movies[4] = "Barbie";
            movies.Capacity = 5;
        }
    }
}
