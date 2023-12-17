using DataStructures.LinkedList;

namespace DataStructures
{
    public class QueueLinkedList<T>
    {
        private MyLinkedList<T> items;

        public void Enqueue(T item)
        {
            items.Add(item);
        }
        public T Dequeue()
        {
            T item = items.Root;

            items.Remove(item);
            return item;
        }

        public T Peek()
        {
            return items.Root;
        }
    }
}
