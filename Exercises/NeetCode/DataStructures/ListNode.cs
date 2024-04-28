using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.DataStructures
{
    public class ListNode
    {
        private int _val;
        private ListNode? _next;
        public int Val { get { return _val; } }
        public ListNode? Next { get { return _next; } set { _next = value; } }
        public ListNode(int val, ListNode? next = null)
        {
            _val = val;
            _next = next;
        }
    }
}
