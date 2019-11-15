using System;

namespace ArraySearchA02
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 10;

            // create an array
            int[] randomNumbers = new int[ARRAY_SIZE];

            // load array with rand #s:
            LoadArray(randomNumbers, ARRAY_SIZE);

            // display array:
            DisplayArray(randomNumbers, ARRAY_SIZE);

            // search array for user-specified #

            Console.ReadLine();
        } // end method

        static void LoadArray(int[] arrayName, int arraySize)
        {
            Random keygen = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                arrayName[i] = keygen.Next(1, 11);
            } // end for
        } // end method

        static void DisplayArray(int[] arrayName, int arraySize)
        {
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Element {i}: {arrayName[i]}");
            } // end for
        } // end method

    } // end class
} // end namespace
