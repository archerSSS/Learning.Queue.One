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
        public void TestCircle()
        {
            Queue<int> que = new Queue<int>();
            for (int i = 0; i < 5; i++) { que.Enqueue(i + 1); }

            que.ReAddHead(2);
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
        public void TestStacksQueue_1()
        {
            Queue_1<int> que = new Queue_1<int>();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);

            Assert.AreEqual(1, que.Dequeue());
            Assert.AreEqual(2, que.Dequeue());
            Assert.AreEqual(3, que.Dequeue());
        }
    }



    public class Queue_1<T>
    {

        Stack<T> stack;

        public Queue_1()
        {
            stack = new Stack<T>();
        }

        public void Enqueue(T item)
        {
            Stack<T> local_stack = new Stack<T>();
            for (int i = stack.Size(); i > 0; i--)
            {
                local_stack.Push(stack.Pop());
            }
            stack.Push(item);
            for (int i = local_stack.Size(); i > 0; i--)
            {
                stack.Push(local_stack.Pop());
            }
        }

        public T Dequeue()
        {
            return stack.Pop();
            // выдача из головы
            return default(T); // если очередь пустая
        }

        public int Size()
        {
            return stack.Size();
            return 0; // размер очереди
        }

        public void ReAddHead(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Enqueue(Dequeue());
            }
        }
    }



    public class Stack<T>
    {

        public DynArray<T> dyn;

        public Stack()
        {
            dyn = new DynArray<T>();
        }

        public int Size()
        {
            if (dyn.count != 0) return dyn.count;
            return 0;
        }

        public T Pop()
        {
            if (dyn.count > 0)
            {
                T val = dyn.GetItem(0);
                dyn.Remove(0);
                if (dyn.count == 0) return val;
                return val;
            }
            return default(T);
        }

        public void Push(T val)
        {
            if (val == null) return;
            dyn.Insert(val, 0);
        }

        public T Peek()
        {
            if (dyn.count != 0)
            {
                return dyn.GetItem(0);
            }
            return default(T);
        }
    }

    public class DynArray<T>
    {

        public T[] array;
        public int count;
        public int capacity;

        public DynArray()
        {
            count = 0;
            MakeArray(16);
        }


        public void MakeArray(int new_capacity)
        {
            if (array != null)
            {
                if (new_capacity < 16) new_capacity = 16;
                capacity = new_capacity;
            }
            else
            {
                array = new T[count];
                capacity = new_capacity;
            }
        }


        public T GetItem(int index)
        {
            if (index < 0 || index >= count) throw new IndexOutOfRangeException();
            return array[index];
            return default(T);
        }


        public void Append(T itm)
        {
            T[] temp_array = new T[count + 1];
            array.CopyTo(temp_array, 0);
            temp_array[count] = itm;
            array = temp_array;
            count++;
            if (count > capacity) MakeArray(capacity * 2);
        }


        public void Insert(T itm, int index)
        {
            if (index < 0 || index > count) throw new IndexOutOfRangeException();
            if (index == count) Append(itm);
            else
            {
                T[] temp_array = new T[count + 1];
                array.CopyTo(temp_array, 0);
                for (int i = count; i > index; i--)
                {
                    temp_array[i] = array[i - 1];
                }
                temp_array[index] = itm;
                array = temp_array;
                count++;
                if (count > capacity) MakeArray(capacity * 2);
            }
        }


        public void Remove(int index)
        {
            if (index < 0 || index >= count) throw new IndexOutOfRangeException();
            T[] temp_array = new T[count - 1];
            for (int i = count - 2; i >= 0; i--)
            {
                if (i >= index) temp_array[i] = array[i + 1];
                else temp_array[i] = array[i];
            }
            array = temp_array;
            count--;
            if (count < capacity / 2) { MakeArray((int)(capacity / 1.5)); }
        }
    }
}
