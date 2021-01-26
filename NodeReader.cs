using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Matrix_Software_Task
{
   public class NodeReader
    {
        public readonly String path = Path.Combine(Directory.GetCurrentDirectory(), "text.txt");
        public string[] text { get; private set; }

        public NodeReader()
        {
            ReadFile();
        }
        private void ReadFile()
        {
            text = System.IO.File.ReadAllLines(path);
        }
       

    }
}
