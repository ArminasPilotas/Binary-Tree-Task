using System;
using System.Collections.Generic;
using System.Text;
using Matrix_Software_Task;
namespace Matrix_Software_Task_Tests.Mocks
{

   public class NodeMockFetcher : NodeFetcher
    {
        private readonly string[] data;

        public NodeMockFetcher(string[] data)
        {
            this.data = data;
        }
        public string[] getData()
        {
            return data;
        }
    }
}
