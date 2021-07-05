using System;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char[,] matrix = new char[N, N];

            for (int row = 0; row < N; row++)
            {
                char[] parametars = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < N; col++)
                {
                    matrix[row, col] = parametars[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());

            for (int rows = 0; rows < N; rows++)
            {
                for (int cols = 0; cols < N; cols++)
                {
                    if ((matrix[rows, cols] == symbol))
                    {
                        Console.WriteLine("(" + rows + ", " + cols + ")");

                        return;
                    }
                }
            }
            Console.WriteLine(symbol + " does not occur in the matrix");
        }
    }
}
