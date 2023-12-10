namespace DataStructures
{
    public class MyList<T>
    {
        private T[] items;
        private int count;

        public MyList()
        {
            items = new T[1];
            count = 0;
        }

        public void Add(T item)
        {
            if (items.Length == count)
            {
                Resize(count * 2);
            }
            items[count++] = item;
        }

        private void Resize(int newSize)
        {
            T[] newItems = new T[newSize];

            for (int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }

            items = newItems;
        }
    }
}
