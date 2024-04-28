using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.DataStructures
{
    public class LinkedList
    {
        private ListNode _head;
        private ListNode _tail;

        public LinkedList()
        {
            _head = new ListNode(-1);
            _tail = _head;
        }

        public int Get(int index)
        {
            ListNode? current = _head.Next;
            int i = 0;
            while(current != null)
            {
                if (i == index)
                    return current.Val;
                i++;
                current = current.Next;
            }
            return -1;
        }

        public void InsertHead(int val)
        {
            ListNode node = new ListNode(val, _head.Next);
            _head.Next = node;
            if(node.Next == null)
                _tail = node;
        }

        public void InsertTail(int val)
        {
            _tail.Next = new ListNode(val, null);
            _tail = _tail.Next;
        }

        public bool Remove(int index)
        {
            int i = 0;
            ListNode? current = _head;
            while (i < index && current != null)
            {
                i++;
                current = current.Next;
            }
            if(current != null && current.Next != null)
            {
                if (current.Next == _tail)
                    _tail = current;
                current.Next = current.Next.Next;
                return true;
            }
            return false;
        }

        public List<int> GetValues()
        {
            List<int> values = new List<int>();
            ListNode? current = _head.Next;
            while(current != null)
            {
                values.Add(current.Val);
                current = current.Next;
            }
            return values;
        }
    }
}
