namespace LeetCode.Problems
{
    public class FibonacciNumberSolution
    {
        public int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            int[] sequence = new int[n + 1];
            sequence[0] = 0;
            sequence[1] = 1;
            for (int i = 2; i <= n; i++)
                sequence[i] = sequence[i - 2] + sequence[i - 1];
            return sequence[n];
        }
    }
}
