using System.Text;

namespace LeetCode.Problems
{
    public class GenerateParenthesesSolution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            Backtrack(result, new StringBuilder(), 0, 0, n);
            return result;
        }

        private void Backtrack(List<string> result, StringBuilder current, int open, int close, int n)
        {
            if (current.Length == 2 * n)
            {
                result.Add(current.ToString());
                return;
            }

            if (open < n)
            {
                current.Append('(');
                Backtrack(result, current, open + 1, close, n);
                current.Length--;
            }

            if (close < open)
            {
                current.Append(')');
                Backtrack(result, current, open, close + 1, n);
                current.Length--;
            }
        }
    }
}
