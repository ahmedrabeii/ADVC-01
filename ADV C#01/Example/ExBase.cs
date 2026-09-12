using System;

namespace ADV_C_01.Example
{
    internal class ExBase
    {
        public class Example<T> where T : Animal
        {
            public void Show(T x)
            {
                x.Eat();
            }
        }
    }
}