using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix_Software_Task
{
    class PathFinder
    {
        private NodeWritter nodeWritter;
        public int largestPathValue { get; private set; }
        public int maxRoutes { get; private set; }


        public PathFinder(NodeWritter nodeWritter)
        {
            this.nodeWritter = nodeWritter;
            largestPathValue = 0;
        }
        private bool CanWeGoDown(int parent, int child)
        {
            if (parent % 2 == 0 && child % 2 == 0) return false;
            else if (parent % 2 != 0 && child % 2 != 0) return false;
            return true;
        }
        public List<List<int>> CalculatePaths(Node node)
        {
            if (!node.HasChildren)
            {
                var result = new List<List<int>>();
                result.Add(new List<int>() { node.Data });
                return result;
            }
            else
            {
                var result = new List<List<int>>();
                if (CanWeGoDown(node.Data,node.LeftChild.Data)) {
                    var leftResults = CalculatePaths(node.LeftChild);
                    foreach (var leftResult in leftResults)
                    {
                        leftResult.Add(node.Data);
                        result.Add(leftResult);
                    }
                }
                if (CanWeGoDown(node.Data,node.RightChild.Data)) {
                    var rightResults = CalculatePaths(node.RightChild);
                    foreach (var rightResult in rightResults)
                    {
                        rightResult.Add(node.Data);
                        result.Add(rightResult);
                    }
                }
                return result;
            }
        }
        public List<int> GetBiggestPath()
        {
            List<int> largestPath = null;
            foreach ( var result in CalculatePaths(nodeWritter.root))
            {
                if (largestPath == null)
                {
                    largestPath = result;
                    largestPathValue = result.Sum();
                    continue;
                }
                var sum = result.Sum();
                if (largestPathValue < sum)
                {
                    largestPathValue = sum;
                    largestPath = result;
                }
            }
            maxRoutes = CalculatePaths(nodeWritter.root).Count;
            largestPath.Reverse();
            return largestPath;
        }
    }
}
