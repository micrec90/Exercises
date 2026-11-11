namespace LeetCode.Problems
{
    public class NextPermutationSolution
    {
        public void NextPermutation(int[] nums)
        {
            int n = nums.Length;

            int i = n - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            if (i >= 0)
            {
                int j = n - 1;
                while (nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);
            }

            Reverse(nums, i + 1, n - 1);
        }

        private void Swap(int[] nums, int i, int j)
        {
            (nums[i], nums[j]) = (nums[j], nums[i]);
        }

        private void Reverse(int[] nums, int left, int right)
        {
            while (left < right)
            {
                Swap(nums, left, right);
                left++;
                right--;
            }
        }
    }
}
