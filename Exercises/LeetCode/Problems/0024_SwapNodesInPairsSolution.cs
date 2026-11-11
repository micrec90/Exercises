using LeetCode.DataStructures;

namespace LeetCode.Problems
{
    public class SwapNodesInPairsSolution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode dummy = new ListNode();
            ListNode prev = dummy;
            ListNode current = head;

            while (current != null && current.next != null)
            {
                prev.next = current.next;
                current.next = prev.next.next;
                prev.next.next = current;

                prev = current;
                current = current.next;
            }

            return dummy.next;
        }
    }
}
