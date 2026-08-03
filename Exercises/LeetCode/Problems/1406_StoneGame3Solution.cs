namespace LeetCode.Problems
{
    internal class StoneGame3Solution
    {
        public string StoneGameIII(int[] stoneValue)
        {
            int n = stoneValue.Length;

            int[] dp = new int[n + 1];
            dp[n] = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                int best = int.MinValue;
                int sum = 0;

                for (int k = 1; k <= 3 && i + k <= n; k++)
                {
                    sum += stoneValue[i + k - 1];
                    int candidate = sum - dp[i + k];
                    best = Math.Max(best, candidate);
                }

                dp[i] = best;
            }

            if (dp[0] > 0)
                return "Alice";
            if (dp[0] < 0)
                return "Bob";
            return "Tie";
        }
    }
}
