using System.Collections.Generic;

namespace ADV_C_01.Example
{
    internal class SafeList<T>
    {
        List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }

        public T Get(int index)
        {
            if (index >= 0 && index < list.Count)
                return list[index];

            return default;
        }
    }
}