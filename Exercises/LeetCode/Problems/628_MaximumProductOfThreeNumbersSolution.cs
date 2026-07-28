namespace LeetCode.Problems
{
    public class MaximumProductOfThreeNumbersSolution
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int product1 = nums[n - 1] * nums[n - 2] * nums[n - 3];
            int product2 = nums[0] * nums[1] * nums[n - 1];
            return Math.Max(product1, product2);
        }
    }
}
