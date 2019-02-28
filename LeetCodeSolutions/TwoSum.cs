using System;
using System.Collections.Generic;
using System.Text;

    //Given an array of integers, return indices of the two numbers such that they add up to a specific target.

    //You may assume that each input would have exactly one solution, and you may not use the same element twice.

namespace LeetCodeSolutions
{
    class TwoSum
    {
        public int[] TwoSums(int[] nums, int target)
        {
            int[] twoSums = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target && i != j)
                    {
                        twoSums[0] = i;
                        twoSums[1] = j;
                        return twoSums;
                    }
                }
            }

            return twoSums;
        }
    }
}
