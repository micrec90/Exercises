using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class ContainsDuplicate2Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if(dict.ContainsKey(nums[i]))
                {
                    if (Math.Abs(dict[nums[i]] - i) <= k)
                        return true;
                }
                dict[nums[i]] = i;
            }
            return false;
        }
    }
}
