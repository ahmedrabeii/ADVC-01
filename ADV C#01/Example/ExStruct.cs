using System;

namespace ADV_C_01.Example
{
    internal class ExStruct
    {
        public class Example<T> where T : struct
        {
            public T Value;

            public Example(T value)
            {
                Value = value;
            }
        }
    }
}