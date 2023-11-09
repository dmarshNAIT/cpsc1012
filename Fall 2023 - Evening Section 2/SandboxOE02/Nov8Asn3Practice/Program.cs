namespace Nov8Asn3Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 5, 2, 5, 6, 3, 4, 3, 8, 4, 9 };
            int result;


            result = SearchArray(ints, 2);
            Console.WriteLine($"We found that number {result} times.");

        }

        static int SearchArray(int[] array, int numberToFind)
        {
            // initialize counter 
            int counter = 0;

            // loop thru the elements in the array
            for (int i = 0; i < array.Length; i++)
            {
                // if they match what I am looking for, then we increment the counter
                if(numberToFind == array[i])
                    counter++;
            }

            // return the counter
            return counter;
        }
    }
}