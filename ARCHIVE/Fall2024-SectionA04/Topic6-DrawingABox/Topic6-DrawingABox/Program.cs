namespace Topic6_DrawingABox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawBox();
            DrawBox(5, 6);
            DrawBox(10, 20);
        }

        /// <summary>
        /// Draws a 5x6 rectangle.
        /// </summary>
        static void DrawBox()
        {
            // draw the top row
            for (int column = 0; column < 6; column++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // draw the middle rows
            for (int row = 0; row < 3; row++)
            {
                Console.Write("*");

                for (int column = 0; column < 4; column++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("*");
            }

            // draw the bottom row
            for (int column = 0; column < 6; column++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Draws a box of a user-specified size.
        /// </summary>
        /// <param name="height"># of rows</param>
        /// <param name="width"># of columns</param>
        static void DrawBox(int height, int width)
        {
            // draw the top row
            for (int column = 0; column < width; column++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // draw the middle rows
            for (int row = 0; row < height - 2; row++)
            {
                Console.Write("*");

                for (int column = 0; column < width - 2; column++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("*");
            }

            // draw the bottom row
            for (int column = 0; column < width; column++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}
