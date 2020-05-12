using System;

namespace ThirtyDaysOfCode.Days
{
    class Node{
        public Node left,right;
        public int data;
        public Node(int data){
            this.data=data;
            left=right=null;
        }
    }
    public class Day22
    {
        static int getHeight(Node root)
        {
            int rightHeight=0,leftHeight=0;
            if(root.left != null)
            {
                leftHeight++;
                leftHeight += getHeight(root.left);
            }
            
            if(root.right!=null)
            {
                rightHeight++;
                rightHeight += getHeight(root.right);
            }

            if(rightHeight>leftHeight)
            {
                return rightHeight;
            }
            return leftHeight;
        }
        static Node insert(Node root, int data)
        {
            if(root==null)
            {
                return new Node(data);
            }
            else{

                Node cur;
                if(data<=root.data)
                {
                    cur=insert(root.left,data);
                    root.left=cur;
                }
                else
                {
                    cur=insert(root.right,data);
                    root.right=cur;
                }
                return root;
            }
        }
        public static void Execute()
        {
            Node root=null;
            int T=Int32.Parse(Console.ReadLine());
            while(T-->0)
            {
                int data=Int32.Parse(Console.ReadLine());
                root=insert(root,data);            
            }
            int height=getHeight(root);
            Console.WriteLine(height);
        }
    }
}