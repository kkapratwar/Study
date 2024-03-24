using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.LeetCode
{
    public class AddTwoNumbersLinkedList
    {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode currentNode = null;
            ListNode firstNode = null;
            int remainder = 0;

            while (l1 != null || l2 != null || remainder != 0)
            {
                var l1Data = l1 == null ? 0 : l1.val;
                var l2Data = l2== null ? 0 : l2.val;

                var addition = l1Data + l2Data + remainder;

                var number = addition % 10;

                remainder = addition / 10;

                var newNode = new ListNode(number);
                if (firstNode == null)
                {
                    firstNode = newNode;
                    currentNode = newNode;
                }
                else
                {
                    currentNode.next = newNode;
                    currentNode = currentNode.next;
                }

                l1 = l1?.next;
                l2 = l2?.next;
            }

            return firstNode;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
