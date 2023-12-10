namespace DataStructures.LinkedList
{
    public class MyLinkedList<T>
    {
        private Node<T> root;

        public void Add(T item)
        {
            if (root == null)
            {
                root = new Node<T>(item);
                return;
            }

            Node<T> iterator = root;

            while (iterator.Next != null)
                iterator = iterator.Next!;

            iterator.Next = new Node<T>(item);
        }

        public void Remove(T item)
        {
            if (root == null)
                return;

            if (root.Value!.Equals(item))
            {
                root = root.Next;
            }

            Node<T> iterator = root;

            while (true)
            {
                if (iterator.Next == null)
                    return;

                if (iterator.Next!.Value!.Equals(item) == false)
                    break;

                iterator = iterator.Next;
            }
            iterator.Next = iterator.Next.Next;
        }

    }
}
