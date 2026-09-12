using System;

namespace ADV_C_01.Example
{
    internal class ExMultiple
    {
        public class Example<T> where T : Animal, IPrint
        {
            public void Show(T x)
            {
                x.Print();
            }
        }
    }
}