namespace LeetCode.Problems
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                int c = target - num;
                if (dict.ContainsKey(c))
                    return new int[] { dict[c], i };
                dict[num] = i;
            }
            return new int[] { };
        }
    }
}
