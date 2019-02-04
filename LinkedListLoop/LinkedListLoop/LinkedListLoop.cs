using System;
using System.Security.Authentication;

namespace LinkedListLoop
{
    public class LinkedListLoop
    {
        public bool HasCycle(Node head)
        {
            if(head==null || head.next==null) return false;
            Node fast = head;
            Node slow = head;
            while (fast.next!=null && fast.next.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;
                
                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }
        
        public Node DetectCycle(Node head) 
        {
            if(head==null || head.next==null) return null;
            Node fast = head;
            Node slow = head;

            while (fast.next!=null && fast.next.next!=null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    slow = head;
                    while (slow!=fast)
                    {
                        slow = slow.next;
                        fast = fast.next;
                    }
                    return slow;
                }
            }
            
            return null;
        }
        
        public Node RemoveElements(Node head, int val)
        {
            if (head == null) return null;
            Node headNode = head;
            while (head.next!=null)
            {
                if (head.next.data == val)
                {
                    Node nodeToDel = head.next;
                    head.next = nodeToDel.next;
                    nodeToDel.next = null;
                    return headNode;
                }

                head = head.next;
            }
            return null;
        }
        
    }
}