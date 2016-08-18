namespace LeetcodeProject
{
    /*
    No.2 Add Two Numbers
    https://leetcode.com/problems/add-two-numbers/

    Total Accepted: 168022
    Total Submissions: 685117
    Difficulty: Medium

    You are given two linked lists representing two non-negative numbers. 
    The digits are stored in reverse order and each of their nodes contain a single digit. 
    Add the two numbers and return it as a linked list.

    Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    Output: 7 -> 0 -> 8
     */
    public class AddTwoNumbersSolution
    {
        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            var upgrade = 0;
            var sum = 0;
            var head = new ListNode(0);
            var temp = new ListNode(0);
            var loopCount = 0;
            var node1 = l1;
            var node2 = l2;
            while (node1 != null || node2 != null)
            {
                sum = upgrade +
                    (node1 != null ? node1.val : 0) +
                    (node2 != null ? node2.val : 0);
                upgrade = sum / 10;
                var node = new ListNode(sum % 10);

                if (loopCount == 0)
                    head = node;
                else
                    temp.next = node;

                temp = node;
                node1 = node1 != null ? node1.next : null;
                node2 = node2 != null ? node2.next : null;
                loopCount++;
            }
            if (upgrade == 1)
            {
                var node = new ListNode(upgrade);
                temp.next = node;
            }

            return head;
        }

    }
}
