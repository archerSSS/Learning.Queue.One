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

            que.Enqueue(1);
            Assert.AreEqual(1, que.Size());
            que.Enqueue(2);
            Assert.AreEqual(2, que.Size());
            int i1 = que.Dequeue();
            Assert.AreEqual(1, que.Size());
            int i2 = que.Dequeue();
            Assert.AreEqual(0, que.Size());
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
        }


        [TestMethod]
        public void TestEnqDeqSize_3()
        {
            Queue<int> que = new Queue<int>();

            que.Enqueue(1);
            que.Enqueue(2);
            int i1 = que.Dequeue();
            Assert.AreEqual(1, que.Size());
            Assert.AreEqual(1, i1);

            que.Enqueue(3);
            Assert.AreEqual(2, que.Size());

            i1 = que.Dequeue();
            Assert.AreEqual(2, i1);
            Assert.AreEqual(1, que.Size());

            i1 = que.Dequeue();
            Assert.AreEqual(3, i1);
            Assert.AreEqual(0, que.Size());
        }


        [TestMethod]
        public void TestEnqDeqSize_4()
        {
            Queue<int> que = new Queue<int>();

            que.Enqueue(1);
            que.Dequeue();
            que.Dequeue();
            Assert.AreEqual(0, que.Size());
        }


        [TestMethod]
        public void TestEnqDeqSize_5()
        {
            Queue<int> que = new Queue<int>();
            Queue<String> que2 = new Queue<String>();

            int i = que.Dequeue();
            bool b = i == null;
            Assert.AreEqual(0, i);
            Assert.AreEqual(false, b);

            String str = que2.Dequeue();
            b = str == null;
            Assert.AreEqual(true, b);
        }


        [TestMethod]
        public void TestEnqSize_1()
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
        public void TestEnqSize_2()
        {
            Queue<int> que = new Queue<int>();
            for (int i = 0; i < 100000000; i++){ que.Enqueue(i+1); }

            int u = que.Size();

            Assert.AreEqual(100000000, u);
        }


        [TestMethod]
        public void TestReAddHead_1()
        {
            Queue<int> que = new Queue<int>();
            for (int i = 0; i < 5; i++) { que.Enqueue(i + 1); }

            que.HeadToTail(2);
            int size = que.Size();
            
            Assert.AreEqual(5, size);

            int q1 = que.Dequeue();
            int q2 = que.Dequeue();
            int q3 = que.Dequeue();
            int q4 = que.Dequeue();
            int q5 = que.Dequeue();

            size = que.Size();

            Assert.AreEqual(3, q1);
            Assert.AreEqual(4, q2);
            Assert.AreEqual(5, q3);
            Assert.AreEqual(1, q4);
            Assert.AreEqual(2, q5);
            Assert.AreEqual(0, size);
        }


        [TestMethod]
        public void TestReAddHead_2()
        {
            Queue<int> que = new Queue<int>();
            que.Enqueue(1);
            que.Enqueue(2);
            que.HeadToTail(1);
            int size = que.Size();

            Assert.AreEqual(2, size);
            Assert.AreEqual(2, que.Dequeue());
            Assert.AreEqual(1, que.Dequeue());
            Assert.AreEqual(0, que.Size());
        }


        [TestMethod]
        public void TestReAddHead_3()
        {
            Queue<int> que = new Queue<int>();
            que.Enqueue(1);
            que.HeadToTail(1);
            
            Assert.AreEqual(1, que.Size());
            Assert.AreEqual(1, que.Dequeue());
            Assert.AreEqual(0, que.Size());
        }


        [TestMethod]
        public void TestStacksQueue_1()
        {
            QueueAdvanced<int> que = new QueueAdvanced<int>();
            
            for (int i = 1; i < 500; i++)
            {
                que.Enqueue(i);
            }

            que.Enqueue(122);

            Assert.AreEqual(1, que.Dequeue());
            Assert.AreEqual(2, que.Dequeue());
            Assert.AreEqual(3, que.Dequeue());
        }


        [TestMethod]
        public void TestStacksQueue_2()
        {
            QueueAdvanced<int> que = new QueueAdvanced<int>();

            for (int i = 1; i < 5; i++)
            {
                que.Enqueue(i);
            }

            que.Dequeue();

            Assert.AreEqual(2, que.Dequeue());
            Assert.AreEqual(3, que.Dequeue());
            Assert.AreEqual(4, que.Dequeue());
        }


        [TestMethod]
        public void TestStacksQueue_3()
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
        public void TestStacksQueue_4()
        {
            Queue<int> que = new Queue<int>();

            que.Enqueue(1);
            Assert.AreEqual(1, que.Size());
            que.Enqueue(2);
            Assert.AreEqual(2, que.Size());
            int i1 = que.Dequeue();
            Assert.AreEqual(1, que.Size());
            int i2 = que.Dequeue();
            Assert.AreEqual(0, que.Size());
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
        }


        [TestMethod]
        public void TestStacksQueue_5()
        {
            Queue<int> que = new Queue<int>();

            que.Enqueue(1);
            que.Enqueue(2);
            int i1 = que.Dequeue();
            Assert.AreEqual(1, que.Size());
            Assert.AreEqual(1, i1);

            que.Enqueue(3);
            Assert.AreEqual(2, que.Size());

            i1 = que.Dequeue();
            Assert.AreEqual(2, i1);
            Assert.AreEqual(1, que.Size());

            i1 = que.Dequeue();
            Assert.AreEqual(3, i1);
            Assert.AreEqual(0, que.Size());
        }


        [TestMethod]
        public void TestStacksQueue_6_HeadToTail()
        {
            Queue<int> que = new Queue<int>();
            for (int i = 0; i < 5; i++) { que.Enqueue(i + 1); }

            que.HeadToTail(2);
            int size = que.Size();

            Assert.AreEqual(5, size);

            int q1 = que.Dequeue();
            int q2 = que.Dequeue();
            int q3 = que.Dequeue();
            int q4 = que.Dequeue();
            int q5 = que.Dequeue();

            size = que.Size();

            Assert.AreEqual(3, q1);
            Assert.AreEqual(4, q2);
            Assert.AreEqual(5, q3);
            Assert.AreEqual(1, q4);
            Assert.AreEqual(2, q5);
            Assert.AreEqual(0, size);
        }


        [TestMethod]
        public void TestStacksQueue_7_HeadToTail()
        {
            Queue<int> que = new Queue<int>();
            que.Enqueue(1);
            que.Enqueue(2);
            que.HeadToTail(1);
            int size = que.Size();

            Assert.AreEqual(2, size);
            Assert.AreEqual(2, que.Dequeue());
            Assert.AreEqual(1, que.Dequeue());
            Assert.AreEqual(0, que.Size());
        }


        [TestMethod]
        public void TestStacksQueue_8_HeadToTail()
        {
            Queue<int> que = new Queue<int>();

            que.HeadToTail(1);

            Assert.AreEqual(0, que.Size());
            Assert.AreEqual(0, que.Dequeue());
        }


        [TestMethod]
        public void TestEnqDeqTimer_1()
        {
            Queue<int> que = new Queue<int>();
            for (int i1 = 0; i1 < 100000; i1++)
            {
                que.Enqueue(i1+1);
            }
            for (int i2 = 0; i2 < 100000; i2++)
            {
                que.Dequeue();
            }
        }
    }
}
