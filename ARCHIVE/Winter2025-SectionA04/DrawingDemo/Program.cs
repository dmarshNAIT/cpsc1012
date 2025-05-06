namespace DrawingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawBox();

            Console.WriteLine("now v2:");
            DrawBox(10, 6);

            Console.WriteLine("And now a tiny box:");
            DrawBox(4, 3);

            Console.WriteLine("Tiny tiny box:");
            DrawBox(1, 1);
        }

        static void DrawBox()
        {
            // print the first line:
            for (int i = 0; i < 10; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();

            // print the middle lines:
            // for each line
            // if it's the first character OR the last character, print *
            // otherwise, print a space
            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    if (column == 0 || column == 9)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }

            // print the last line:
            for (int i = 0; i < 10; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        static void DrawBox(int width, int height) // overloaded method!
        {
            if (width < 2 || height < 2) // defensive coding
            {
                Console.WriteLine("Sorry, that's too tiny.");
            }
            else
            {
                // print the first line:
                for (int i = 0; i < width; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();

                // print the middle lines:
                // for each line
                // if it's the first character OR the last character, print *
                // otherwise, print a space
                for (int row = 0; row < (height - 2); row++)
                {
                    for (int column = 0; column < width; column++)
                    {
                        // if it's the first or last column, print a *:
                        if (column == 0 || column == (width - 1))
                        {
                            Console.Write('*');
                        }
                        // otherwise, print a space
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }

                // print the last line:
                for (int i = 0; i < width; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

    }
}
