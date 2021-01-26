using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_Software_Task
{
    public class NodeFromFileFormat : NodeFormat
    {
        private Node AddRoot(int value, List<Node> currentNodes)
        {
            var root = new Node(value);
            currentNodes.Add(root);
            return root;
        }
        private void AddChildrens(int value, int index, List<Node> previousNodes, List<Node> currentNodes)
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

        public Node FormatData(string[] data)
        {
            Node root = default(Node);
            List<Node> previousNodes = new List<Node>();

            foreach (String row in data)
            {
                List<Node> currentNodes = new List<Node>();
                var columns = row.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < columns.Length; i++)
                {
                    if (previousNodes.Count == 0)
                    {
                        root = AddRoot(int.Parse(columns[i]), currentNodes);
                    }
                    else
                    {
                        AddChildrens(int.Parse(columns[i]), i, previousNodes, currentNodes);
                    }
                }
                previousNodes = currentNodes;
            }
            return root;
        }
    }
}
