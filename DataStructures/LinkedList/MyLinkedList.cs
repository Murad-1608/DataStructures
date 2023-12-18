using System.Collections;

namespace DataStructures.LinkedList
{
    public class MyLinkedList<T>  /*IEnumerable*/
    {
        private Node<T> root;
        private Node<T> last;
        public int age { get; set; }

        public int age1;
        public T Root
        {
            get
            {
                return root.Value;
            }
        }
        public T Last
        {
            get
            {
                return last.Value;
            }
        }
        public void Add(T item)
        {
            Node<T> newItem = new Node<T>(item);
            if (root == null)
            {
                root = newItem;
                last = newItem;
                return;
            }

            //Node<T> iterator = root;

            //while (iterator.Next != null)
            //    iterator = iterator.Next!;

            //iterator.Next = newItem;
            Node<T> previous = last;

            last.Next = newItem;
            last = newItem;
            last.Previous = previous;
        }

        //public IEnumerator GetEnumerator()
        //{            
        //    while ()
        //    {

        //    }
        //    yield return 
        //}

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

        public void AddFirst(T item)
        {
            var next = root.Next;
            root = new Node<T>(item);
            root.Next = next;
        }
        public void RemoveFirst()
        {
            root = root.Next;
        }
        public void RemoveLast()
        {
            last = last.Previous;
        }


    }
}
