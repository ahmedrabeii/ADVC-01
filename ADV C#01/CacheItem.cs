using System;

namespace ADV_C_01
{
    internal class CacheItem<T>
    {
        public T Value;
        public DateTime Expiration;
    }
}