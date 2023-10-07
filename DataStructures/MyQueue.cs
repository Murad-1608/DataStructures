namespace DataStructures
{
    public class MyQueue<T>
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

            return item;
        }

        private void ThrowIfEmpty()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");
        }

        public bool IsEmpty() => count == 0;

    }
}
