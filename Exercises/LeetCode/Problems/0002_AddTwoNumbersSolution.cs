using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            int carry = 0;
            while (l1 != null || l2 != null || carry > 0)
            {
                int v1 = l1 != null ? l1.val : 0;
                int v2 = l2 != null ? l2.val : 0;

                int val = v1 + v2 + carry;
                carry = val / 10;
                val = val % 10;
                current.next = new ListNode(val);
                current = current.next;

                l1 = l1 != null ? l1.next : null!;
                l2 = l2 != null ? l2.next : null!;
            }

            return dummy.next;
        }
    }
}