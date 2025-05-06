namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a List of strings
            List<string> juiceHut = new List<string>();

            // add some juices to the list
            juiceHut.Add("orange");
            juiceHut.Add("mango");
            juiceHut.Add("strawberry");
            juiceHut.Add("grape");
            juiceHut.Add("peach");

            // print out the values of the properties
            Console.WriteLine("The Capacity of the List is " + juiceHut.Capacity);
            Console.WriteLine("The Count of the List is " + juiceHut.Count);
            juiceHut.TrimExcess();

            // edit/remove/insert
            juiceHut.Insert(2, "peach mango");
            juiceHut.Remove("peach");
            juiceHut[4] = "peach";
            Console.WriteLine("The Capacity of the List is " + juiceHut.Capacity);
            Console.WriteLine("The Count of the List is " + juiceHut.Count);
        }
    }
}
