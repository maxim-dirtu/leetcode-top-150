using LeetCodeTop150.Problems;

class Program
{
    static void Main(string[] args)
    {
        char[][] board = new char[][]
       {
    new char[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
    new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
    new char[] { '.', '9', '.', '.', '.', '.', '.', '6', '.' },
    new char[] { '.', '.', '.', '.', '6', '.', '.', '.', '3' },
    new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
    new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
    new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
    new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
    new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
       };

        var result = Problem036_ValidSudoku.IsValidSudoku(board);

        Console.WriteLine(result);

    }
}
