using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_Software_Task
{
    class NodeWritter
    {
        private NodeReader nodeReader;
        public Node root { get; private set; }
        private List<Node> previousNodes;
        public List<Node> currentNodes { get; private set; }

        public NodeWritter()
        {
            nodeReader = new NodeReader();
            previousNodes = new List<Node>();
        }
        public void WriteToNode()
        {
            foreach (String row in nodeReader.text)
            {
                currentNodes = new List<Node>();
                var columns = row.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < columns.Length; i++)
                {
                    if (previousNodes.Count == 0)
                    {
                        AddRoot(int.Parse(columns[i]));
                    }
                    else
                    {
                        AddChildrens(int.Parse(columns[i]), i);
                    }
                }
                previousNodes = currentNodes;
            }
        }
        private void AddRoot(int value)
        {
            root = new Node(value);
            currentNodes.Add(root);
        }
        private void AddChildrens(int value,int index)
        {
            Node child = new Node(value);
            currentNodes.Add(child);
            var leftParentIndex = index - 1;
            var rightParentIndex = index;
            if (leftParentIndex >= 0)
            {
                previousNodes[leftParentIndex].RightChild = child;
            }
            if (rightParentIndex < previousNodes.Count)
            {
                previousNodes[rightParentIndex].LeftChild = child;
            }
        }
    }
}
