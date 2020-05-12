using System;

namespace ThirtyDaysOfCode.Days
{
    public static class Day15
    {
        private class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data=d;
                next=null;
            }   
        }
        private static void lookNull(Node nextNode,Node newNode){
            if(nextNode.next==null){
                nextNode.next=newNode;
            }else{
                lookNull(nextNode.next,newNode);
            }
        }
        private static Node insert(Node head,int data)
        {
            if(head == null){
                head = new Node(data);
                return head;
            }else{
                Node newNode = new Node(data);
                lookNull(head,newNode);
                return head;
            }
        }

        private static void display(Node head)
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
            while(T-->0)
            {
                int data=Int32.Parse(Console.ReadLine());
                head=insert(head,data);
            }
            display(head);
        }
    }
}