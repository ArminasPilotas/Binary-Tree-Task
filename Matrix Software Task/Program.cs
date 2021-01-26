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
            Console.Write("Enter a file name for example text.txt : ");
            string fileName = Console.ReadLine();
            PathFinder pathFinder = new PathFinder(new NodeReaderFromFile(fileName), new NodeFromFileFormat());
          
            Console.Write("Path: {0}",string.Join(",",pathFinder.GetBiggestPath()));
            Console.WriteLine();
            Console.WriteLine("Sum : {0}", pathFinder.largestPathValue);
            Console.WriteLine("All possible routes: {0}", pathFinder.maxRoutes);
            Console.ReadKey();
        }
        

    }
}
