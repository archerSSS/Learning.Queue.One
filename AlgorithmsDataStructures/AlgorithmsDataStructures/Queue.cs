using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Queue<T>
    {

        List<T> list;

        public Queue()
        {
            list = new List<T>();
        }

        public void Enqueue(T item)
        {
            list.Add(item);
        }

        public T Dequeue()
        {
            if (list.Count != 0)
            {
                T item = list.Find(delegate (T it) { return it.GetType() == typeof(T); });
                list.RemoveAt(0);
                return item;
            }
            return default(T);
        }

        public int Size()
        {
            return list.Count;
            return 0;
        }

        public void ReAddHead(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Enqueue(Dequeue());
            }
        }
    }
}