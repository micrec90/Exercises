namespace LeetCode.Problems
{
    public class StoneGame2Solution
    {
        public int StoneGameII(int[] piles)
        {
            int n = piles.Length;
            int[,] dp = new int[n, n + 1];
            int sum = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                sum += piles[i];
                for (int m = 1; m <= i / 2 + 1; m++)
                {
                    if (i + m * 2 >= n)
                        dp[i, m] = sum;
                    else
                    {
                        int mn = int.MaxValue;
                        for (int x = 1; x <= m * 2; x++)
                            mn = Math.Min(mn, dp[i + x, Math.Max(m, x)]);
                        dp[i, m] = sum - mn;
                    }
                }
            }

            return dp[0, 1];
        }
    }
}
