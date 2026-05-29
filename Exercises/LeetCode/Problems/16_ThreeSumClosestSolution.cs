namespace LeetCode.Problems
{
    public class ThreeSumClosestSolution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int closest = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (Math.Abs(sum - target) < Math.Abs(closest - target))
                        closest = sum;

                    if (sum == target)
                        return sum;
                    else if (sum < target)
                        left++;
                    else
                        right--;
                }
            }

            return closest;
        }
    }
}