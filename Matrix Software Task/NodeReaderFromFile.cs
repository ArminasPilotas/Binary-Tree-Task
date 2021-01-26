using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Matrix_Software_Task
{
   public class NodeReaderFromFile : NodeFetcher
    {
        public readonly String path;
        public NodeReaderFromFile(String fileName)
        {
            path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
        }
        public string[] getData()
        {
            try
            {
                return System.IO.File.ReadAllLines(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return new string[0];
            }
        }
    }
}
