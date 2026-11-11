using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            for (int index = digits.Length - 1; index >= 0; --index)
            {
                if (digits[index] == 9)
                    digits[index] = 0;
                else
                {
                    ++digits[index];
                    return digits;
                }
            }
            digits = new int[digits.Length + 1];
            digits[0] = 1;

            return digits;
        }
    }
}
