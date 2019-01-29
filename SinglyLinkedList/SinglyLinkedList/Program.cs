using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Linkedlist l = new Linkedlist();
            l.AddAtHead(1);
            //l.AddAtTail(3);
            l.AddAtIndex(1,2);
            //Console.WriteLine("Hello World! "+ l.GetNodeAt(1).data);
            Console.WriteLine("Hello World! "+ 
                              l.Get(2));

//            l.DeleteAtIndex(0);
//            l.PrintList();
            
            
        }
    }
}