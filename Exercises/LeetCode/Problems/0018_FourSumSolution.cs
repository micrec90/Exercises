namespace LeetCode.Problems
{
    public class FourSumSolution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            int length = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < length - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                long minSum = (long) nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3];
                if (minSum > target)
                    break;

                long maxSum = (long) nums[i] + nums[length - 1] + nums[length - 2] + nums[length - 3];
                if (maxSum < target)
                    continue;

                for (int j = i + 1; j < length - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                        continue;

                    long minSum2 = (long) nums[i] + nums[j] + nums[j + 1] + nums[j + 2];
                    if (minSum2 > target)
                        break;

                    long maxSum2 = (long) nums[i] + nums[j] + nums[length - 1] + nums[length - 2];
                    if (maxSum2 < target)
                        continue;

                    int left = j + 1, right = length - 1;

                    while (left < right)
                    {
                        long total = (long) nums[i] + nums[j] + nums[left] + nums[right];

                        if (total == target)
                        {
                            result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                            left++;
                            right--;
                            while (left < right && nums[left] == nums[left - 1])
                            {
                                left++;
                            }
                            while (left < right && nums[right] == nums[right + 1])
                            {
                                right--;
                            }
                        }
                        else if (total < target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }

            return result;
        }
    }
}
