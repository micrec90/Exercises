namespace LeetCode.Problems
{
    public class MergeKSortedListsSolution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            return Partition(lists, 0, lists.Length - 1);
        }

        private ListNode Partition(ListNode[] lists, int left, int right)
        {
            if (left > right)
                return null;
            if (left == right)
                return lists[left];

            int mid = left + (right - left) / 2;
            ListNode leftHalf = Partition(lists, left, mid);
            ListNode rightHalf = Partition(lists, mid + 1, right);

            return Merge(leftHalf, rightHalf);
        }

        private ListNode Merge(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            current.next = list1 ?? list2;
            return dummy.next;
        }
    }
}
