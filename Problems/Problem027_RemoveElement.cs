using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LeetCodeTop150.Problems
{
    public class Problem027_RemoveElement
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int[] expectedNums = new int[nums.Length];
            int arrayCount = 0;

            foreach (int i in nums)
            {
                if (i != val)
                {
                    expectedNums[arrayCount] = i;
                    arrayCount++;
                }
            }

            for(int i = 0; i< arrayCount; i++)
            {
                nums[i] = expectedNums[i];

            }

            return arrayCount;
        }

        public static int RemoveElementOptimal(int[] nums, int val)
        {
            int k = 0;
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
                i++;
            }
            return k;
        }
   
    }
}
