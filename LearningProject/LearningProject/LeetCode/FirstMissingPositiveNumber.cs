using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.LeetCode
{
    /*
     Write a function:

        class Solution { public int solution(int[] A); }

    that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

    For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

    Given A = [1, 2, 3], the function should return 4.

    Given A = [−1, −3], the function should return 1.

    Write an efficient algorithm for the following assumptions:

        * N is an integer within the range [1..100,000];
        * each element of array A is an integer within the range [−1,000,000..1,000,000].
     
     */
    public class FirstMissingPositiveNumber
    {
        public int FirstPositiveMissingNumber(int[] nums)
        {
            int swapper;
            int num;
            int res = 1;
            int i = 0;
            while (i < nums.Length)
            {
                num = nums[i];
                if (num != i + 1 && num > 0 && num <= nums.Length && nums[num - 1] != nums[i])
                {
                    swapper = nums[num - 1];
                    nums[num - 1] = num;
                    nums[i] = swapper;
                }
                else
                {
                    i++;
                }
            }
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] == res)
                    res++;
                else if (nums[i] > res)
                    return res;
            }
            return res;
        }
    }
}
