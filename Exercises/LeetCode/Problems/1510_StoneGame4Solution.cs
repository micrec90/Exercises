namespace LeetCode.Problems
{
    public class StoneGame4Solution
    {
        static bool[] dp;
        public bool WinnerSquareGame(int n)
        {
            return dp[n];
        }
        static StoneGame4Solution()
        {
            const int n = 100001;
            dp = new bool[n + 1];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j * j <= i; j++)
                {
                    if (!dp[i - j * j])
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }
        }
    }
}
