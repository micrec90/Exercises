namespace LeetCode.Problems
{
    public class KthLargestElementInAnArraySolution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                priorityQueue.Enqueue(nums[i], nums[i]);
                if (priorityQueue.Count > k)
                    priorityQueue.Dequeue();
            }
            return priorityQueue.Peek();
        }
    }
}
