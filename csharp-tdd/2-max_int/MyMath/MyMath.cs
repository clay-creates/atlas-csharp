using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Class for mathmatic functions
    /// </summary>
    public static class Operations
    {
        /// <summary>
        /// Function to find the largest number in a list of ints
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }

            int max = nums[0];
            foreach (var num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
