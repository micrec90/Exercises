namespace LeetCode.Problems
{
    public class SearchInsertPositionSolution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid;
            }

            return left;
        }
    }
}
