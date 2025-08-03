using LeetCodeTop150.Problems;

class Program
{
    static void Main(string[] args)
    {

        int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
            int val = 2;
        int result = 0;


       result = Problem027_RemoveElement.RemoveElement(nums, val);

        Console.WriteLine(result);

    }
}
