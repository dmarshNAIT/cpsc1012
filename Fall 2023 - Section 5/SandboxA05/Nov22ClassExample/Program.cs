using System.Collections.Concurrent;

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

            Console.WriteLine("\n\n" + flyingSpaghettiMonster.DisplayInfo());

            // playing around with lists:
            List<Deity> deities = new List<Deity>();
            deities.Add(defaultDeity);
            deities.Add(flyingSpaghettiMonster);

            deities.Capacity = 10;
            //Deity[] deityArray = new Deity[deities.Count];
            //deities.CopyTo(deityArray); 

            // search the list:
            bool flyingSpaghettiMonsterExists = SearchForDeity(deities, "Bob");

            if (flyingSpaghettiMonsterExists)
                Console.WriteLine("We have a deity by that name!");
            else
                Console.WriteLine("There is no deity by that name.");

            Console.WriteLine("\n\nGoodbye!");
        }

        /// <summary>
        /// This method will search for deities using a sequential search algorithm.
        /// </summary>
        /// <param name="list">The List to search</param>
        /// <param name="deityName">Search criteria</param>
        /// <returns>true if any deities match this criteria.</returns>
        static bool SearchForDeity(List<Deity> list, string deityName)
        {
            bool isFound = false;

            foreach (Deity deity in list)
            {
                // check if the name matches:
                if (deity.GetName().Equals(deityName))
                {
                    isFound = true;
                }
            }

            return isFound;
        }
    }
}