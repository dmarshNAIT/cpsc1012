namespace DrawingARectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawRectangle();

            Console.WriteLine("Now to use the overload:");
            DrawRectangle(2, 2);
            Console.WriteLine("Now another one!");
            DrawRectangle(1, 1);
        }

        /// <summary>
        /// Draws a box that is 7 characters wide & 4 characters tall
        /// </summary>
        static void DrawRectangle()
        {
            // draw the top row
            for (int column = 0; column < 7; column++)
            {
                Console.Write('~');
            }
            Console.WriteLine();

            // draw the middle rows
            for (int row = 0; row < 2; row++)
            {
                Console.Write('~');

                for (int column = 0; column < 5; column++)
                {
                    Console.Write(' ');
                }

                Console.WriteLine('~');
            }

            // draw the bottom row
            for (int column = 0; column < 7; column++)
            {
                Console.Write('~');
            }
            Console.WriteLine();
        }

        static void DrawRectangle(int height, int width)
        {
            if (height < 2 || width < 2)
            {
                Console.WriteLine("Sorry, can't do that.");
            }
            else
            {
                // draw the top row
                for (int column = 0; column < width; column++)
                {
                    Console.Write('~');
                }
                Console.WriteLine();

                // draw the middle rows
                for (int row = 0; row < height - 2; row++)
                {
                    Console.Write('~');

                    for (int column = 0; column < width - 2; column++)
                    {
                        Console.Write(' ');
                    }

                    Console.WriteLine('~');
                }

                // draw the bottom row
                for (int column = 0; column < width; column++)
                {
                    Console.Write('~');
                }
                Console.WriteLine();
            }
        }
    }
}
