using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class LongestPalindromicSubstringSolution
    {
        public string LongestPalindrome(string s)
        {
            // Using Manacher's Algorithm
            if (s.Length <= 1)
                return s;

            int max = 1;
            string ret = s.Substring(0, 1);
            s = '|' + string.Join('|', s.ToCharArray()) + '|';

            int[] lpsLengths = new int[s.Length];
            int center = 0;
            int right = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if (i < right)
                    lpsLengths[i] = Math.Min(right - i, lpsLengths[2 * center - i]);

                while(i - lpsLengths[i] - 1 >= 0 && i + lpsLengths[i] + 1  < s.Length && s[i - lpsLengths[i] - 1] == s[i + lpsLengths[i] + 1])
                {
                    lpsLengths[i]++;
                }
                if(i + lpsLengths[i] > right)
                {
                    center = i;
                    right = i + lpsLengths[i];
                }
                if (lpsLengths[i] > max)
                {
                    max = lpsLengths[i];
                    ret = s.Substring(i - lpsLengths[i], 2 * lpsLengths[i] + 1).Replace("|", "");
                }
            }

            return ret;
        }
    }
}
