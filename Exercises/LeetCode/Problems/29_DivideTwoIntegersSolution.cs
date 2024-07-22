using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class DivideTwoIntegersSolution
    {
        public int Divide(int dividend, int divisor)
        {
            bool isNegative = false;
            int ret = 0;
            if (dividend == divisor)
                return 1;
            if ((dividend > 0 && divisor < 0) || (dividend < 0 && divisor > 0))
                isNegative = true;

            long udividend = Math.Abs((long)dividend);
            long udivisor = Math.Abs((long)divisor);

            while(udividend >= udivisor)
            {
                int count = 0;
                while(udividend > (udivisor << count + 1))
                {
                    ++count;
                }
                udividend -= udivisor << count;
                ret += 1 << count;
            }
            if(ret == (1<< 31) && isNegative == false) return int.MaxValue;

            if (isNegative)
                return 0 - ret;
            return ret;
        }
    }
}
