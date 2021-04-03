using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Queue<T> : IEnumerable<T>
    {
        private T[] node;
        private uint current;
        private uint size;
        public Queue(uint size)
        {
            this.size = size;
            this.current = 0;
            node = new T[Size];
        }
        public Queue() : this(0) { }
        public uint Current
        {
            get => current;
        }
        public uint Size
        {
            get => size;
        }
        public void Add(T elem)
        {
            node[Current] = elem;
            current++;
            if (Current >= node.Length)
            {
                current = 0;
            }
        }
        public void Extract()
        {
            T[] tmp = node;
            int j = 0;
            for (int i = 1; i < node.Length; i++)
            {
                node[j] = tmp[i];
                ++j;
            }
            node[size - 1] = default(T);
        }
        public T Top()
        {
            return node[0];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in node)
            {
                yield return item;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in node)
            {
                yield return item;
            }
        }
    }
}
