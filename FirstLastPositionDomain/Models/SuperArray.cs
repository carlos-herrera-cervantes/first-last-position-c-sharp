using System;
using System.Collections.Generic;

namespace FirstLastPositionDomain.Models
{
    public static class SuperArray
    {
        /// <summary>Returns the indices in which the target number appears</summary>
        /// <param name="nums">Array of numbers</param>
        /// <param name="target">Number to search</param>
        /// <returns>List that includes the indices in which appears the target number</returns>
        public static List<int> SearchRange(int[] nums, int target)
        {
            var baseResult = new List<int> { -1, -1 };

            if (nums.Length == 0) return baseResult;

            var result = new List<int>();

            result.Add(FindLeft(nums, target));
            result.Add(FindRight(nums, target));

            return result;
        }

        /// <summary>Finds the left index for target number</summary>
        /// <param name="nums">Array of numbers</param>
        /// <param name="target">Number to search</param>
        /// <returns>If finds the index, it returns it, otherwise returns -1</returns>
        private static int FindLeft(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left + 1 < right)
            {
                int middle = left + (right - left) / 2;

                if (nums[middle] < target) left = middle;
                else right = middle;
            }

            if (nums[left] == target) return left;
            if (nums[right] == target) return right;

            return -1;         
        }

        /// <summary>Finds the right index for target number</summary>
        /// <param name="nums">Array of numbers</param>
        /// <param name="target">Number to search</param>
        /// <returns>If finds the index, it returns it, otherwise returns -1</returns>
        private static int FindRight(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left + 1 < right)
            {
                int middle = left + (right - left) / 2;

                if (nums[middle] <= target) left = middle;
                else right = middle;
            }

            if (nums[right] == target) return right;
            if (nums[left] == target) return left;

            return -1;
        }
    }
}