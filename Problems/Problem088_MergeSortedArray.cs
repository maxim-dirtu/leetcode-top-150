using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetCodeTop150.Problems
{
    public class Problem088_MergeSortedArray
    {
        //my solution
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] sorted = new int[m + n];

            int nums1Counter = 0;
            int nums2Counter = 0;

            int total = m + n;

            for (int i = 0; i < total; i++)
            {
                if (nums1Counter >= m && nums2Counter < n)
                {
                    sorted[i] = nums2[nums2Counter];
                    nums2Counter++;
                    continue;
                }
                else if (nums2Counter >= n && nums1Counter < m)
                {
                    sorted[i] = nums1[nums1Counter];
                    nums1Counter++;
                    continue;
                }

                if (nums1[nums1Counter] < nums2[nums2Counter])
                {
                    sorted[i] = nums1[nums1Counter];
                    nums1Counter++;
                }
                else
                {
                    sorted[i] = nums2[nums2Counter];
                    nums2Counter++;

                }

            }

            for (int i = 0; i < total; i++)
            {
                nums1[i] = sorted[i];
            }

        }

        //optimal solution
        public static void MergeOptimal(int[] nums1, int m, int[] nums2, int n)
        {
            int last = m + n - 1;

            while (m > 0 && n > 0)
            {
                if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[last] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[last] = nums2[n - 1];
                    n--;
                }

                last--;
            }
            while (n > 0)
            {
                nums1[last] = nums2[n - 1];
                n--;
                last--;
            }
        }


    }
}
