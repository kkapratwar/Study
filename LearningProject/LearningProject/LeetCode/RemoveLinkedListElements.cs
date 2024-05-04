using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.LeetCode
{
    internal class RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return head;
            }

            while (head != null && head.val == val)
            {
                head = head.next;
            }

            ListNode currentNode = head;

            while (head != null && head.next != null)
            {
                if (head.next.val == val)
                {
                    head.next = head.next.next;
                }
                else
                {
                    head = head.next;
                }
            }

            return currentNode;
        }
    }
}
