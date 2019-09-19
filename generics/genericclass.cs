using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class GenericClass<Y>
    {
        public GenericClass(Y val)
        {
            GetY = val;
        }
        public Y GetY { get; private set; }
        public T GetSum<T>(T first, T second) 
        {
            dynamic f = first;
            dynamic s = second;
            return f + s; 
        }
    }
}
