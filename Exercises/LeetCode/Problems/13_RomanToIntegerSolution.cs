using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class RomanToIntegerSolution
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        public int RomanToInt(string s)
        {
            int answer = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((i < s.Length - 1) && (dictionary[s[i]] < dictionary[s[i + 1]]))
                    answer -= dictionary[s[i]];
                else
                    answer += dictionary[s[i]];
            }
            return answer;
        }
    }
}
