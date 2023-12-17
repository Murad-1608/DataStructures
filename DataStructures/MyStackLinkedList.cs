using DataStructures.LinkedList;

namespace DataStructures
{
    public class MyStackLinkedList<T>
    {
        private MyLinkedList<T> items;

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            var item = items.Last;

            items.Remove(item);

            return item;
        }

        public T Peek()
        {
            return items.Last;
        }
    }
}
