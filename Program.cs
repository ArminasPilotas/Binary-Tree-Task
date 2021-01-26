using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Matrix_Software_Task
{
    class Program
    {
        static void Main(string[] args)
        {
        
            NodeWritter nodeWritter = new NodeWritter();
            nodeWritter.WriteToNode();
            PathFinder pathFinder = new PathFinder(nodeWritter);

            
            Console.Write("Path: {0}",string.Join(",",pathFinder.GetBiggestPath()));
            Console.WriteLine();
            Console.WriteLine("Sum : {0}", pathFinder.largestPathValue);
            Console.WriteLine("All possible routes: {0}", pathFinder.maxRoutes);
        }
        

    }
}
