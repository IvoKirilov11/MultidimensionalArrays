using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cows = dimensions[1];

            Console.WriteLine(rows);
            Console.WriteLine(cows);

            int[,] matrix = new int[rows, cows];

            for (int row = 0; row < rows; row++)
            {
                int []currentRow = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int cow = 0; cow < cows; cow++)
                {
                    matrix[row, cow] = currentRow[cow];
                }
            }
            long sum = 0;
            foreach (var element in matrix)
            {
                sum += element;
            }
            Console.WriteLine(sum);
        }
    }
}
