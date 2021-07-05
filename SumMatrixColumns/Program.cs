using System;
using System.Linq;

namespace SumMatrixColumns
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
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int cow = 0; cow < cows; cow++)
                {
                    matrix[row, cow] = currentRow[cow];
                }
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumOfColons = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfColons += matrix[row, col];
                }
                Console.WriteLine(sumOfColons);
            }
        }
    }
}
