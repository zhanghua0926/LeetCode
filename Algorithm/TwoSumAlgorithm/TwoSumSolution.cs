using System;
using System.Collections.Generic;

namespace Algorithm.SumOfTwoNumAlgorithm
{
    public static class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }

                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
            }

            throw new InvalidOperationException("No two sum solution");
        }
    }
}
