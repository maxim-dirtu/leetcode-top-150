using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTop150.Problems
{
    public class Problem036_ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            //THE SUDOKU BOARD IS 9X9


            //CHECK ROWS
            //for each row create an array of all the numbers on it
            //check for duplicates in a row
            for(int i=0; i < 9; i++)
            {
                List<char> row = new List<char>();

                for (int j=0; j<9; j++)
                {
                    if (Char.IsDigit(board[i][j])) row.Add(board[i][j]);

                }

                foreach(char c in row)
                {
                    var result = row.FindAll(x => x == c);
                    if (result.Count > 1) return false;
                }

            }
            Console.WriteLine("Passed row check");

            //CHECK COLUMNS

            for (int i = 0; i < 9; i++)
            {
                List<char> column = new List<char>();

                for (int j = 0; j < 9; j++)
                {
                    if (Char.IsDigit(board[j][i])) column.Add(board[j][i]);

                }

                foreach (char c in column)
                {
                    var result = column.FindAll(x => x == c);
                    if (result.Count > 1) return false;
                }

            }

            Console.WriteLine("Passed column check");



            //CHECK BOXES
            for (int i = 0; i < 9; i=i+3)
            {
                List<char> box = new List<char>();

                for (int j = 0; j < 9; j = j + 3)
                {

                    Console.WriteLine($"Checking the box [{i},{j}]-[{i + 2},{j + 2}]");
                    for (int m = i; m< (i + 3); m++)
                    {
                        for( int n = j; n< (j + 3); n++)
                        {
                            if (Char.IsDigit(board[m][n])) box.Add(board[m][n]);


                        }
                    }

                    foreach (char c in box)
                    {
                        Console.WriteLine($"checking the char: {c}");
                        var result = box.FindAll(x => x == c);
                        if (result.Count > 1) return false;
                    }

                    box.Clear();
                }


            }


            //VALID SUDOKU
            return true;
        }
    }
}
