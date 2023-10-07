using System.Collections;

namespace DataStructures
{
    public class MyStack<T> : IEnumerable
    {
        private const int DEFAULT_SIZE = 50;

        private T[] elements;
        private int top = -1;
        public MyStack(int initialSize = DEFAULT_SIZE)
        {
            elements = new T[initialSize];
        }

        public void Push(T item)
        {
            top++;
            elements[top] = item;
        }

        public T Pop()
        {
            if (top == elements.Length - 1)
            {
                Extend();
            }
            T item = elements[top];
            elements[top--] = default;
            if (top > 0 && top > elements.Length / 4)
                Shrink();

            return item;
        }

        private void Extend()
        {
            var newArray = new T[elements.Length * 2];
            Array.Copy(elements, newArray, elements.Length);
            elements = newArray;
        }
        private void Shrink()
        {
            var newArray = new T[elements.Length / 2];
            Array.Copy(elements, 0, newArray, 0, top + 1);
            elements = newArray;
        }

        public IEnumerator GetEnumerator()
        {
            return elements.GetEnumerator();
        }
    }

}
