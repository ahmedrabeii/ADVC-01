using System;

namespace ADV_C_01.Example
{
    internal class ExClass
    {
        public class Example<T> where T : class
        {
            public T Value;

            public Example(T value)
            {
                Value = value;
            }
        }
    }
}