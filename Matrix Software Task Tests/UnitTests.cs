using Matrix_Software_Task;
using Matrix_Software_Task_Tests.Mocks;
using NUnit.Framework;
using System.Collections.Generic;

namespace Matrix_Software_Task_Tests
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void RegularTest()
        {
            PathFinder pathFinder = new PathFinder(new NodeMockFetcher(new string[4] {"1", "8 9", "1 5 9", "4 5 2 3" }),new NodeFromFileFormat());
            Assert.That(pathFinder.GetBiggestPath(),Is.EquivalentTo(new List<int>() {1,8,5,2}));
        }
        [Test]
        public void RegularTest2()
        {
            PathFinder pathFinder = new PathFinder(new NodeMockFetcher(new string[4] { "1", "9 8", "1 5 9", "4 5 2 3" }), new NodeFromFileFormat());
            Assert.That(pathFinder.GetBiggestPath(), Is.EquivalentTo(new List<int>() { 1,8,9,2 }));
        }


    }
}