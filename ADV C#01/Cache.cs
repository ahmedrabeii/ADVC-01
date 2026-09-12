using System;
using System.Collections.Generic;

namespace ADV_C_01
{
    internal class Cache<TKey, TValue>
    {
        Dictionary<TKey, CacheItem<TValue>> data =
            new Dictionary<TKey, CacheItem<TValue>>();

        public void Add(TKey key, TValue value, int seconds)
        {
            data[key] = new CacheItem<TValue>();

            data[key].Value = value;
            data[key].Expiration = DateTime.Now.AddSeconds(seconds);
        }

        public TValue Get(TKey key)
        {
            if (Contains(key))
                return data[key].Value;

            return default;
        }

        public void Remove(TKey key)
        {
            data.Remove(key);
        }

        public bool Contains(TKey key)
        {
            if (!data.ContainsKey(key))
                return false;

            if (DateTime.Now > data[key].Expiration)
            {
                Remove(key);
                return false;
            }

            return true;
        }
    }
}