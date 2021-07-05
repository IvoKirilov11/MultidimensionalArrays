using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cows = dimensions[1];



            int[,] matrix = new int[rows, cows];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int cow = 0; cow < cows; cow++)
                {
                    matrix[row, cow] = currentRow[cow];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    int currSum = matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1];

                    if(currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxRow,maxCol]} {matrix[maxRow,maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
