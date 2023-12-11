namespace Nov22ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a new object
            Deity defaultDeity = new Deity();
            Deity flyingSpaghettiMonster = new Deity("FSM", true, true, 100);

            Console.WriteLine($"The god's name is {flyingSpaghettiMonster.GetName()}.");

            flyingSpaghettiMonster.SetName("Bob");

            Console.WriteLine($"The god's name is {flyingSpaghettiMonster.GetName()}.");

            Console.WriteLine(flyingSpaghettiMonster.Inspire());

            List<Deity> deities = new List<Deity>();
            deities.Add(defaultDeity);
            deities.Add(flyingSpaghettiMonster);

            deities.Capacity = 10;
            //Deity[] deityArray = new Deity[deities.Count];
            //deities.CopyTo(deityArray); 


            Console.WriteLine("Goodbye!");
        }
    }
}