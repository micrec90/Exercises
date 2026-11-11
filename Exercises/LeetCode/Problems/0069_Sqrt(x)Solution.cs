using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class Sqrt_x_Solution
    {
        public int MySqrt(int x)
        {
            if (x == 0) return 0;

            int left = 1, right = x, result = 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (mid <= x / mid)
                {
                    result = mid;
                    left = mid + 1;
                }
                else
                    right = mid - 1;
            }

            return result;
        }
    }
}
