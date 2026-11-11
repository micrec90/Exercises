using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class LongestSubstringWithoutRepeatingCharactersSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> chars = new HashSet<char>();
            int max = 0;
            int left = 0;
            int right = 0;

            while(right < s.Length)
            {
                if (!chars.Contains(s[right]))
                {
                    chars.Add(s[right]);
                    max = Math.Max(max, right - left + 1);
                }
                else
                {
                    while (chars.Contains(s[right]))
                    {
                        chars.Remove(s[left]);
                        left++;
                    }
                }
                chars.Add(s[right]);
                right++;
            }
            return max;
        }
    }
}
