namespace LeetCode.Problems
{
    public class LongestValidParenthesesSolution
    {
        public int LongestValidParentheses(string s)
        {
            int left = 0, right = 0, max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    left++;
                else
                    right++;

                if (left == right)
                    max = Math.Max(max, 2 * right);
                else if (right > left)
                    left = right = 0;
            }

            left = right = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '(')
                    left++;
                else
                    right++;

                if (left == right)
                    max = Math.Max(max, 2 * left);
                else if (left > right)
                    left = right = 0;
            }

            return max;
        }
    }
}
