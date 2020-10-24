using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDSProblem;

namespace LinkedListUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Data_When_Searched_Should_Return_Found_Or_NotFound()
        {
            int data = 30;
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Node node = list.SearchNode(30);
            Assert.AreEqual(data, node.data);
        }
    }
}
