using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class CountingBitsSolution
    {
        public int[] CountBits(int n)
        {
            int[] result = new int[n+1];
            if(n == 0)
                return result;
            result[0] = 0;
            if(n >= 1)
                result[1] = 1;

            for(int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                    result[i] = result[i / 2];
                else
                    result[i] = result[i / 2] + 1;
            }
            return result;
        }
    }
}
