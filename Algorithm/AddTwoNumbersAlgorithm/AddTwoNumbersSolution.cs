using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.AddTwoNumbersAlgorithm
{
    public static class AddTwoNumbersSolution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null || l1.val == 0)
                return l2;
            if (l2 == null || l2.val == 0)
                return l1;

            ListNode sumNode = new ListNode();
            ListNode node = sumNode;
            int num = 0, carryNum = 0;
            while (l1 != null && l2 != null)
            {
                num = (l1.val + l2.val) % 10;
                sumNode.val = num + carryNum;
                carryNum = (l1.val + l2.val + carryNum) / 10;

                l1 = l1.next;
                l2 = l2.next;
                sumNode.next = new ListNode();
                sumNode = sumNode.next;
            }

            if (l1 == null)
            {
                while (l2 != null)
                {
                    sumNode.val = (carryNum + l2.val) % 10;
                    carryNum = (carryNum + l2.val) / 10;
                    if (l2.next != null)
                    {
                        l2 = l2.next;
                        sumNode.next = new ListNode();
                        sumNode = sumNode.next;
                    }
                    else
                        break;
                }
            }
            else if (l2 == null)
            {
                while (l1 != null)
                {
                    sumNode.val = (carryNum + l1.val) % 10;
                    carryNum = (carryNum + l1.val) / 10;
                    if (l1.next != null)
                    {
                        l1 = l1.next;
                        sumNode.next = new ListNode();
                        sumNode = sumNode.next;
                    }
                    else
                        break;
                }
            }

            if (carryNum > 0)
                sumNode.next = new ListNode(carryNum, null);

            return node;
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
