using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_Software_Task
{
    class Node
    {
        public int Data { get; private set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public bool HasChildren { get { return LeftChild != null || RightChild != null; } }
     

       public Node(int data)
        {
            this.Data = data;
        }
    }
}
