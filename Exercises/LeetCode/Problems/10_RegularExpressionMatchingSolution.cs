namespace LeetCode.Problems
{
    public class RegularExpressionMatchingSolution
    {
        public bool IsMatch(string s, string p)
        {
            int m = s.Length;
            int n = p.Length;

            bool[] result = new bool[n + 1];

            result[0] = true;

            for (int j = 2; j <= n; j++)
            {
                if (p[j - 1] == '*')
                    result[j] = result[j - 2];
            }

            for(int i = 1; i <= m; i++)
            {
                bool[] current = new bool[n + 1];
                for (int j = 1; j <= n; j++)
                {
                    if (p[j - 1] == '*')
                    {
                        // "It is guaranteed for each appearance of the character '*', there will be a previous valid character to match."
                        bool zeroUse = current[j - 2];
                        bool prevMatches = p[j - 2] == s[i - 1] || p[j - 2] == '.';
                        bool onePlusUse = prevMatches && result[j];

                        current[j] = zeroUse || onePlusUse;
                    }
                    else if (p[j - 1] == '.' || p[j - 1] == s[i - 1])
                        current[j] = result[j - 1];
                }

                result = current;
            }
            return result[n];
        }
    }
}
