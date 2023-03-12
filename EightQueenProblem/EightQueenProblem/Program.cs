using System;

namespace EightQueenProblem
{
    public class Program
    {
        static int count = 0;

        static void Main(string[] args)
        {
            int size = 13;
            EightQueens(new bool[size, size], new int[size, size], 0);
            Console.WriteLine(count);
        }

        static void EightQueens(bool[,] board, int[,] occupeid, int columnIndex)
        {
            if (columnIndex == board.GetLength(0))
            {
                count++;
                return;
            }

            for (int rowIndex = 0; rowIndex < board.GetLength(0); rowIndex++)
            {
                if (occupeid[rowIndex,columnIndex] == 0)
                {
                    // Place queen EightQueens()
                    board[rowIndex, columnIndex] = true;

                    // Mark impossible elements in board
                    Occupeid(occupeid, +1, rowIndex, columnIndex);

                    // Recursivly call EightQueens()
                    EightQueens(board, occupeid, columnIndex + 1);
                    board[rowIndex, columnIndex] = false;

                    //Unmark impossible elements in board
                    Occupeid(occupeid, -1, rowIndex, columnIndex);
                }
            }
        }

        static void Occupeid(int[,] occupeid, int value, int row, int column)
        {
            for (int i = 0; i < occupeid.GetLength(0); i++)
            {
                // For lines
                occupeid[row, i] += value;
                occupeid[i, column] += value;

                // For diagonals
                if (column + i < occupeid.GetLength(0) 
                    && row + i < occupeid.GetLength(0))
                {
                    occupeid[row + i, column + i] += value;
                }

                if (column + i < occupeid.GetLength(0)
                   && row - i >= 0)
                {
                    occupeid[row - i, column + i] += value;
                }
            }
        }
    }
}
