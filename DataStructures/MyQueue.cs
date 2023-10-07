using System.Collections;
using System.Runtime.CompilerServices;

namespace DataStructures
{
    public class MyQueue<T> : IEnumerable
    {
        private const int DEFAULT_SIZE = 50;

        private T[] elements;
        private int head = 0;
        private int tail = -1;
        private int count = 0;
        public MyQueue(int initial = DEFAULT_SIZE)
        {
            elements = new T[initial];
        }

        public void Enqueue(T item)
        {
            if (count == elements.Length)
            {
                Extend();
            }
            tail++;
            elements[tail] = item;
            count++;
        }

        public T Dequeue()
        {
            ThrowIfEmpty();

            T item = elements[head];
            elements[head] = default;
            head++;
            count--;

            if (count > 0 && count == elements.Length / 4)
            {
                Shrink();
            }

            return item;
        }

        private void ThrowIfEmpty()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");
        }

        public bool IsEmpty() => count == 0;

        private void Extend()
        {
            Array.Resize(ref elements, elements.Length * 2);
            head = 0;
            tail = count - 1;
        }
        private void Shrink()
        {
            int capacity = elements.Length / 2;
            var newArray = new T[capacity];

            Array.Copy(elements, head, newArray, 0, count);
            elements = newArray;

            head = 0;
            tail = count - 1;

        }

        public IEnumerator GetEnumerator()
        {
            return elements.GetEnumerator();
        }
    }
}
