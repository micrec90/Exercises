using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class MajorityElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            int candidate = nums[0];
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(count == 0)
                    candidate = nums[i];
                if (candidate == nums[i])
                    count++;
                else
                    count--;
            }
            return candidate;
        }
    }
}
