namespace LeetCode.Problems
{
    public class RunningSumOf1dArraySolution
    {
        public int[] RunningSum(int[] nums)
        {
            int sum = 0;
            int[] ret = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                ret[i] = sum;
            }
            return ret;
        }
    }
}
