/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
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


    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int length = Length(head);
        int i = length - n;
        if(n >  length|| length == 1)  return null;
        if(i==0) return head.next;

        ListNode myHead = head;
        while (--i>0)
        {
            head = head.next;
        }

        ListNode nodeToDel = head.next;
        head.next = nodeToDel.next;
        nodeToDel.next = null;
        return myHead;
    }
}