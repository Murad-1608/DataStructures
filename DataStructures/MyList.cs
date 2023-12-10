using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace DataStructures
{
    public class MyList<T> : IEnumerable
    {
        private T[] items;
        private int count;

        public MyList()
        {
            items = new T[1];
            count = 0;
        }
        public MyList(int capacity)
        {
            items = new T[capacity];
            count = 0;
        }
        #region Properties
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return items.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
        #endregion

        #region Methods
        public void Add(T item)
        {
            if (items.Length == count)
            {
                Resize(count * 2);
            }
            items[count++] = item;
        }

        public void Remove(T item)
        {
            int index = IndexOf(item);

            if (index == -1)
                return;

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            count--;

            if (items.Length / 4 == count)
            {
                Resize(items.Length / 2);
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i]!.Equals(item))
                    return i;
            }
            return -1;
        }

        private void Resize(int newSize)
        {
            T[] newItems = new T[newSize];

            for (int i = 0; i < items.Length && i < newSize; i++)
            {
                newItems[i] = items[i];
            }
            items = newItems;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
        #endregion
    }
}
