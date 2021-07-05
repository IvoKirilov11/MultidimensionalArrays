using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] currentRow = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();
                jagged[row] = currentRow;

            }

           
            for (int row = 0; row < rows - 1; row++)
            {
                double[] firstArr = jagged[row];
                double[] secondArr = jagged[row + 1];
                if (firstArr.Length == secondArr.Length)
                {
                    jagged[row] = firstArr.Select(e => e * 2).ToArray();
                    jagged[row + 1] = secondArr.Select(e => e * 2).ToArray();
                }
                else
                {
                    jagged[row] = firstArr.Select(e => e / 2).ToArray();
                    jagged[row + 1] = secondArr.Select(e => e / 2).ToArray();
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    foreach (double[] currentRow in jagged)
                    {
                        Console.WriteLine(string.Join(' ', currentRow));
                    }
                    break;

                }

                string[] commandParts = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                int row = int.Parse(commandParts[1]);
                int col = int.Parse(commandParts[2]);
                int value = int.Parse(commandParts[3]);

                if (row < 0
                    || row >= rows
                    || col < 0
                    || col >= jagged[row].Length)
                {
                    continue;
                }


                else if (commandParts[0] == "Add")
                {
                    jagged[row][col] += value;
                }
                else if (commandParts[0] == "Subtract")
                {
                    jagged[row][col] -= value;
                }

                
            }
        }
    }
}
