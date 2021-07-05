using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = dimensions[0];
            int m = dimensions[1];

           

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine()
                        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int maxSum = int.MinValue;
            int rowIndex = -1;
            int colIndex = -1;

            for (int rows = 0; rows < n - 2; rows++)
            {
                for (int cols = 0; cols < m - 2; cols++)
                {
                    int sum = matrix[rows, cols];
                    sum += matrix[rows, cols + 1];
                    sum += matrix[rows, cols + 2];

                    sum += matrix[rows + 1, cols];
                    sum += matrix[rows + 1, cols + 1];
                    sum += matrix[rows + 1, cols + 2];

                    sum += matrix[rows + 2, cols];
                    sum += matrix[rows + 2, cols + 1];
                    sum += matrix[rows + 2, cols + 2];


                    if(sum>maxSum)
                    {
                        maxSum = sum;
                        rowIndex = rows;
                        colIndex = cols;
                    }
                }
                
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = rowIndex; row < rowIndex + 3; row++)
            {
                for (int col = colIndex; col < colIndex + 3; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
