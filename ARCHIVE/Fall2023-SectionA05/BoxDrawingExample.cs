using System;
using System.Globalization;

namespace TestBox
{
    internal class BoxDrawingExample
    {
        static void Main(string[] args)
        {
            DrawRectangle(50,17);
        }

        static void DrawRectangle(int numColumns, int numRows)
        {
            string box = "";

            // print top row
            box += DrawStars(numColumns);
            box += "\n";

            // print contents
            for (int line = 0; line < numRows - 2; line++ ){
                // print asterisk
                box += "*";

                // print a bunch of spaces
                for(int col = 0; col < numColumns -2; col++)
                {
                    box += " ";
                }

                // print another asterisk
                box += "*\n";
            }

            // print bottom row
            box += DrawStars(numColumns);
            Console.WriteLine(box);
        }

        static string DrawStars(int numColumns)
        {
            string box = "";
            for (int col = 0; col < numColumns; col++)
            {
                box += "*";
            }
            return box;
        }

    }

}