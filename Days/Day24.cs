using System;
using System.Collections.Generic;
namespace ThirtyDaysOfCode.Days
{
    public class Day24
    {
        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data=d;
                next=null;
            }
                
        }
        static Node removeDuplicates(Node head)
        {
            List<int> items = new List<int>();
            Node next = head;
            while(next != null)
            {
                int data = next.data;
                if(items.IndexOf(data)==-1)
                {
                    items.Add(data);
                }
                next=next.next;
            }
            head = null;
            items.Sort();
            foreach(int item in items)
            {
                head = insert(head,item);
            }
            return head;
        }
        static Node insert(Node head,int data)
        {
            Node p=new Node(data);
            if(head==null)
                head=p;
            else if(head.next==null)
                head.next=p;
            else
            {
                Node start=head;
                while(start.next!=null)
                    start=start.next;
                start.next=p;
                
            }
            return head;
        }
        static void display(Node head)
        {
            Node start=head;
            while(start!=null)
            {
                Console.Write(start.data+" ");
                start=start.next;
            }
        }
        public static void Execute()
        {
            Node head=null;
            int T=Int32.Parse(Console.ReadLine());
            while(T-->0){
                int data=Int32.Parse(Console.ReadLine());
                head=insert(head,data);
            }
            head=removeDuplicates(head);
            display(head);
        }
    }
}