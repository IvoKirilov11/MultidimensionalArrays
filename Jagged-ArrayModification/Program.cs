using System;
using System.Linq;

namespace Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                jagged[row] = currentRow;

            }
            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if(command == "end")
                {
                    foreach (int[]currentRow in jagged)
                    {
                        Console.WriteLine(string.Join(' ',currentRow));
                    }
                    break;
                }

                string[] commandParts = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(commandParts[1]);
                int col = int.Parse(commandParts[2]);
                int value = int.Parse(commandParts[3]);

                if(row < 0 
                    || row >=rows 
                    ||col < 0
                    || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }


                else if (commandParts[0]== "add")
                {
                    jagged[row][col] += value;
                }
                else if(commandParts[0]=="subtract")
                {
                    jagged[row][col] -= value;
                }
            }
        }
    }
}
