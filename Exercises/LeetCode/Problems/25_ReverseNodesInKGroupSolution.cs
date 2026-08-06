namespace LeetCode.Problems
{
    public class ReverseNodesInKGroupSolution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode groupPrevious = dummy;

            while (true)
            {
                ListNode kth = groupPrevious;
                for (int i = 0; i < k && kth != null; i++)
                {
                    kth = kth.next;
                }

                if (kth == null) break;

                ListNode groupNext = kth.next;
                ListNode previous = groupNext;
                ListNode current = groupPrevious.next;

                while (current != groupNext)
                {
                    ListNode temp = current.next;
                    current.next = previous;
                    previous = current;
                    current = temp;
                }

                ListNode temp2 = groupPrevious.next;
                groupPrevious.next = kth;
                groupPrevious = temp2;
            }

            return dummy.next;
        }
    }
}
