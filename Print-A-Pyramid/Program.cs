using System;

namespace Print_a_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangleHeight, triangleWidth;
            triangleHeight = 5;
            triangleWidth = 9;

            for (int i = 0; i < triangleHeight; i++)
            {
                // We divide triangleWidth by 2 since we only need to print spaces on 1 side of the triangle
                // We subtract by i since we need less spaces as we loop through the rows
                for (int j = 0; j < (triangleWidth / 2) - i; j++)
                {
                    Console.Write(' ');
                }

                // We add 1 to print the center of the triangle
                // We multiply i by 2 to print the sides of the triangle in incremental steps
                for (int j = 0; j < 1 + (i * 2); j++)
                {
                    Console.Write('*');
                }

                Console.Write("\n");
            }
        }
    }
}
