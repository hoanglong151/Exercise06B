using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STACK;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStack()
        {
            Stack acc = new Stack(10);
        }

        [TestMethod]
        public void TestPush()
        {
            Stack S = new Stack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual(3,S.Count());
        }
        [TestMethod]
        public void TestPop()
        {
            Stack S = new Stack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual("3", S.Pop());
            Assert.AreEqual("2", S.Pop());
        }
        [TestMethod]
        public void TestPeek()
        {
            Stack S = new Stack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            Assert.AreEqual("3", S.Peek());
            Assert.AreEqual(3, S.Count());
         }
        [TestMethod]
        public void TestClear()
        {
            Stack S = new Stack();
            S.Push("1");
            S.Push("2");
            S.Push("3");
            S.Clear();
            Assert.AreEqual(0, S.Count());
        }
    }
}
