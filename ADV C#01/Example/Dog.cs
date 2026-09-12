using System;

namespace ADV_C_01.Example
{
    internal class Dog : Animal, IPrint
    {
        public void Print()
        {
            Console.WriteLine("Dog");
        }
    }
}