using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDSProblem;
using System.Collections.Generic;

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
        [TestMethod]
        public void Given_ValueToInsert_AfterParticularValue_Should_Return_Inserted_Or_NotInserted()
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Node expected = list.SearchNode(30);
            int expected2 = expected.next.data;
            Node node = list.InsertAfterNode(40,30);
            int result = node.next.data;
            Assert.AreEqual(expected2, result);
        }
        [TestMethod]
        public void Given_ValueToDelete_OfParticularKey_Should_Return_DeletedOrNot_And_SizeOfUpdatedlist()
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.DeleteNodeOfKey(40);
            Node node = list.SearchNode(30);
            int result = node.next.data;
            int expected = 70;
            Assert.AreEqual(expected, result);
        }
    }
}

