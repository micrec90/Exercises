using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class PalindromeNumberSolution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || x != 0 && x % 10 == 0)
                return false;
            int result = 0;
            while(x > result)
            {
                result = result * 10 + x % 10;
                x /= 10;
            }
            if (x == result || x == result / 10)
                return true;
            return false;
        }
    }
}
