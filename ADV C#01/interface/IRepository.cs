using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_C_01.@interface
{
    interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        T Get(int index);
    }
}
