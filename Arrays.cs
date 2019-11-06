using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {

            const int ARRAY_SIZE = 10;
            int[] ages = new int[ARRAY_SIZE];

            LoadArray(ages, ARRAY_SIZE, 10);
            DisplayArray(ages, ARRAY_SIZE);

            Console.WriteLine("What number shall I search for?");
            int searchNum = int.Parse(Console.ReadLine());
            bool isFound = SearchArray(ages, searchNum, ARRAY_SIZE);

            if (!isFound)
                Console.WriteLine("Sorry, that number does not exist in this array.");

            Console.ReadLine();
        } // end method

    
        static void LoadArray(int[] arrayName, int arraySize, int maxRand)
        {
            Random keygen = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                arrayName[i] = keygen.Next(1, maxRand);
            }
        } // end method

        static void DisplayArray(int[] arrayName, int arraySize)
        {
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"The element at index {i} is {arrayName[i]}");
            }
        } // end method

        static bool SearchArray(int[] arrayName, int searchNumber, int arraySize)
        {
            bool isFound = false;

            for (int i = 0; i < arraySize && !isFound; i++)
            {
                if (arrayName[i] == searchNumber)
                {
                    Console.WriteLine("The number exists in the array!");
                    isFound = true;
                } // end if
            } // end for
            return isFound;
        } // end method


    } // end class
} // end namespace
