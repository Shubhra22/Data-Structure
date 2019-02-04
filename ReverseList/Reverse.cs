/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Reverse {
    public ListNode ReverseList(ListNode head)
    {
        public ListNode ReverseList(ListNode head)
        {
            if(head==null) return null;
            ListNode node;
            ListNode headNode = head;
            while (head.next!=null)
            {
                node = head.next;
                head.next = node.next;
                node.next = headNode;
                headNode = node; 
            }
            return headNode;
        }
    }
}