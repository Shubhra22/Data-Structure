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
    }
}