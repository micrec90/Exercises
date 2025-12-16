namespace LeetCode.Problems
{
    public class SquaresOfASortedArraySolution
    {
        public int[] SortedSquares(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int[] ret = new int[nums.Length];

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    ret[i] = nums[left] * nums[left];
                    left++;
                }
                else
                {
                    ret[i] = nums[right] * nums[right];
                    right--;
                }
            }
            return ret;
        }
    }
}
