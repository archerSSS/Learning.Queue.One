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
            // вставка в хвост
        }

        public T Dequeue()
        {
            T item = list.Find(delegate(T it) { return it.GetType() == typeof(T); });
            list.RemoveAt(0);
            return item;
            // выдача из головы
            return default(T); // если очередь пустая
        }

        public int Size()
        {
            return list.Count;
            return 0; // размер очереди
        }

    }
}