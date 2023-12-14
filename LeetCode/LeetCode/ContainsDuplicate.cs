using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class ContainsDuplicate
    {
        //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

        public static bool ContainsDuplicateFunction(int[] nums)
        {
            //Solution 1
            //var containsduplicate = false;
            //int tmp;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    tmp = nums[i];
            //    for (int j = i+1; j < nums.Length; j++)
            //    {
            //        if (nums[j] == tmp)
            //        {
            //            containsduplicate = true;
            //            break;
            //        }
            //    }

            //}
            //return containsduplicate;

            //Solution 2: 

            //Dictionary<int, int> d = new Dictionary<int, int>();
            //d = nums.GroupBy(n => n).ToDictionary(g => g.Key, g => g.Count());
            //if (d.Any(_ => _.Value > 1)) return true;
            //return false;

            //Solution 3 - best so far: 

            HashSet<int> hs = new();
            var inputLength = nums.Length;
            foreach (var item in nums)
            {
                if (hs.Contains(item))
                {
                    return true;
                }
                hs.Add(item);
                
            }
            if (hs.Count < inputLength)
            {
                return true;
            }
            return false;
        }
    }
}
