using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEnqDeqSize_1()
        {
            Queue<int> que = new Queue<int>();
            que.Enqueue(5);
            que.Enqueue(15);
            que.Enqueue(25);
            
            int i1 = que.Dequeue();
            int i2 = que.Dequeue();
            int i3 = que.Dequeue();
            int size = que.Size();

            Assert.AreEqual(5, i1);
            Assert.AreEqual(15, i2);
            Assert.AreEqual(25, i3);
            Assert.AreEqual(0, size);
        }


        [TestMethod]
        public void TestEnqDeqSize_2()
        {
            Queue<int> que = new Queue<int>();
            int size = que.Size();
            Assert.AreEqual(0, size);

            que.Enqueue(5);
            size = que.Size();
            Assert.AreEqual(1, size);

            que.Enqueue(15);
            size = que.Size();
            Assert.AreEqual(2, size);

            que.Enqueue(25);
            size = que.Size();
            Assert.AreEqual(3, size);

            que.Dequeue();
            size = que.Size();
            Assert.AreEqual(2, size);
        }


        [TestMethod]
        public void TestEnqDeqSize_3()
        {
            Queue<int> que = new Queue<int>();
            for (int i = 0; i < 100000000; i++){ que.Enqueue(i+1); }

            int u = que.Size();

            Assert.AreEqual(100000000, u);
        }
    }
}
