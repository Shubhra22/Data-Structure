using System;

namespace SinglyLinkedList
{
    public class Linkedlist
    {
        private Node head;
        private Node tail;
        private int length;

        public Linkedlist()
        {
            head = tail = null;
            length = 0;
        }

        public Node GetNodeAt(int index)
        {
            Node n = head;
            while (index > 0)
            {
                n = n.next;             
                index--;
            }
            return n;
        }
        
        public int Get(int index)
        {
            if (index >= length) return -1;
            return GetNodeAt(index).data;
        }
        public void AddAtHead(int val)
        {
            if (head == null)
            {
                head = new Node(val);
            }
            else
            {
                Node n = new Node(val);
                n.next = head;
                head = n;
            }

            length++;
        }

        public void AddAtTail(int val)
        {
            Node n = head;
            int i = 0;
            while (i < length - 1)
            {
                n = n.next;
                i++;
            }

            Node newNode = new Node(val);
            n.next = newNode;
            length++;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index < 0 || index > length) return;
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            if (index == length)
            {
                AddAtTail(val);
                return;
            }

            Node n = head;
            while (index > 1)
            {
                n = n.next;
                index--;
            }

            Node newNode = new Node(val);
            newNode.next = n.next;
            n.next = newNode;

            length++;
        }

        public void DeleteAtIndex(int index)
        {
            Node n = head;
            if (index == 0)
            {
                head = n.next;
                n.next = null;
            }
            else
            {
                while (index-- > 1)
                {
                    n = n.next;
                }
                Node dNode = n.next;
                n.next = dNode.next;
                dNode.next = null;
            }
            length--;
        }

        public void PrintList()
        {
            int i = 0;
            Node n = head;
            while (i < length)
            {
                Console.WriteLine(n.data);
                n = n.next;
                i++;
            }
        }
    }
}