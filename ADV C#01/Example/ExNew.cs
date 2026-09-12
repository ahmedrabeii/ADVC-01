using System;

namespace ADV_C_01
{
    internal class ExNew
    {
        public class Example<T> where T : new()
        {
            public T CreateObject()
            {
                return new T();
            }
        }

        internal class Person
        {
        }
    }
}