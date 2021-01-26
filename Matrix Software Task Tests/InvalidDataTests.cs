using Matrix_Software_Task;
using Matrix_Software_Task_Tests.Mocks;
using NUnit.Framework;
using System.Collections.Generic;

namespace Matrix_Software_Task_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void NoDataTest()
        {
            PathFinder pathFinder = new PathFinder(new NodeMockFetcher(new string[0]),new NodeFromFileFormat());
            Assert.Throws<System.NullReferenceException>(
                () => {
                    pathFinder.GetBiggestPath();
                }
                );
        }

        [Test]
        public void BadDataTest()
        {
            PathFinder pathFinder = new PathFinder(new NodeMockFetcher(new string[2] {"1","1"}), new NodeFromFileFormat());
            Assert.Throws<System.NullReferenceException>(
                () => {
                    pathFinder.GetBiggestPath();
                }
                );
        }
    }
}