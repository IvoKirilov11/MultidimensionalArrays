using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            int primeryDiagonal = 0;
            int secondDiagonal = 0;
            int count = n - 1;

            for (int row = 0; row < n; row++)
            {
                primeryDiagonal += matrix[row, row];
                secondDiagonal += matrix[row, count];
                count--;
            }
            Console.WriteLine(primeryDiagonal);
        }
    }
}
