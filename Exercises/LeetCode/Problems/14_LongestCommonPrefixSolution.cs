using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            string prefix = strs[0];
            int prefixLength = prefix.Length;
            for (int i = 1; i < strs.Length; i++)
            {
                string next = strs[i];
                while (prefixLength > next.Length || prefix != next.Substring(0, prefixLength))
                {
                    prefixLength--;
                    if (prefixLength == 0)
                        return "";
                    prefix = prefix.Substring(0, prefixLength);
                }
            }
            return prefix;
        }
    }
}
