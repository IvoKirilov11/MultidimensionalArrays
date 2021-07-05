using System;
using System.Linq;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine()
                        .ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    chessBoard[row, col] = rowData[col];
                }
            }
            int countRepleice = 0;
            int rowKiller = 0;
            int colKiller = 0;

            while (true)
            {
                int maxAttak = 0;
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char currSymbol = chessBoard[row, col];
                        int countAttack = 0;
                        if(currSymbol == 'K')
                        {
                            if(IsInside(chessBoard,row - 2,col +1) && chessBoard[row - 2, col + 1] == 'K')
                            {

                                countAttack++;
                            }
                            if (IsInside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {

                                countAttack++;
                            }
                            if (IsInside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {

                                countAttack++;
                            }
                            if (IsInside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {

                                countAttack++;
                            }
                            if (IsInside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {

                                countAttack++;
                            }
                            if (IsInside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {

                                countAttack++;
                            }
                            if (IsInside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {

                                countAttack++;
                            }
                            if (IsInside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {

                                countAttack++;
                            }

                            if(countAttack > maxAttak)
                            {
                                maxAttak = countAttack;
                                rowKiller = row;
                                colKiller = col;
                            }


                        }
                    }
                }

                if(maxAttak> 0)
                {
                    chessBoard[rowKiller, colKiller] = '0';
                    countRepleice++;

                }


                else
                {
                    Console.WriteLine(countRepleice);
                    break;
                }
            }
        }

        private static bool IsInside(char[,] chessBoard, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < chessBoard.GetLength(0)
                && targetCol >= 0 && targetCol < chessBoard.GetLength(1);
        }
    }
}
