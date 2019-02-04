/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class LinkedListLoop {
    
    public int Length(ListNode head)
    {
        int counter = 0;
        while (head != null)
        {
            head = head.next;
            counter++;
        }

        return counter;
    }
    
    
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        int diff = Length(headA) - Length(headB);

        if (diff > 0)
        {
            while (diff-->0)
            {
                headA = headA.next;
            }
        }
        else if (diff < 0)
        {
            int c = Math.Abs(diff);
            while (c-->0)
            {
                headB = headB.next;
            }
        }

        while (headA!=headB)
        {
            if (headA == null || headB == null) return null;
            headA = headA.next;
            headB = headB.next;
        }


        return headA;
    }
}