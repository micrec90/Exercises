namespace LeetCode.Problems
{
    public class FindFirstAndLastPositionOfElementInSortedArraySolution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int first = FindBound(nums, target, true);
            if (first == -1) return new[] { -1, -1 };

            int last = FindBound(nums, target, false);
            return new[] { first, last };
        }

        private int FindBound(int[] nums, int target, bool findFirst)
        {
            int lower = 0, higher = nums.Length - 1, result = -1;

            while (lower <= higher)
            {
                int middle = lower + (higher - lower) / 2;

                if (nums[middle] == target)
                {
                    result = middle;
                    if (findFirst)
                        higher = middle - 1;
                    else
                        lower = middle + 1;
                }
                else if (nums[middle] < target)
                    lower = middle + 1;
                else
                    higher = middle - 1;
            }

            return result;
        }
    }
}
