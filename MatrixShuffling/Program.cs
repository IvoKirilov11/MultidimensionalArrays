using System;
using System.Linq;

namespace MatrixShuffling
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



            string[,] matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                string[] rowData = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            
            while (true)
            {
                string command = Console.ReadLine();
                if(command == "END")
                {
                    break;
                }
                string[] commanData = command.Split();

                if(commanData.Length != 5 || commanData[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    
                    continue;
                }

                int rowOne = int.Parse(commanData[1]);
                int colOne = int.Parse(commanData[2]);
                int rowTwo = int.Parse(commanData[3]);
                int colTwo = int.Parse(commanData[4]);

                bool isValidONe = isValidOCell(rowOne, colOne, n, m);
                bool isValidTwo = isValidOCell(rowTwo, colTwo, n, m);

                if(!isValidONe || !isValidTwo)
                {
                    Console.WriteLine("Invalid input!");

                    continue;
                }

                string valueOne = matrix[rowOne, colOne];
                string valueTwo = matrix[rowTwo, colTwo];

                matrix[rowOne, colOne] = valueTwo;
                matrix[rowTwo, colTwo] = valueOne;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < m; col++)
                    {
                        Console.Write(matrix[row,col] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static bool isValidOCell(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
        }
    }
}
