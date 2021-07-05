using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] pascalTriungle = new long[rows][];


            if(rows >= 1)
            {
                pascalTriungle[0] = new long[] { 1 };
            }
            if(rows >= 2)
            {
                pascalTriungle[1] = new long[] { 1, 1 };
            }
            for (int row = 2; row < rows; row++)
            {
                pascalTriungle[row] = new long[row + 1];
                pascalTriungle[row][0] = 1;
                for (int col = 1; col < row; col++)
                {
                    pascalTriungle[row][col] = pascalTriungle[row - 1][col]  + pascalTriungle[row - 1][col - 1];
                }

                pascalTriungle[row][row] = 1;
            }

            foreach (long[] currentRow in pascalTriungle)
            {
                Console.WriteLine(string.Join(" ", currentRow));
            }
        }
    }
}
