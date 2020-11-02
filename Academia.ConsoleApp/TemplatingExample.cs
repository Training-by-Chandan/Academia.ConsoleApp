using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.ConsoleApp
{
    public class TemplatingExample<T1, T2>
    {
        public T1 Func1(T1 a)
        {
            //some logic here
            return a;
        }

        public T2 Func2( T2 b)
        {
            //some logic here
            return b;
        }

        public void Func3(T1 a, T2 b)
        {
            //some logic here
        }
    }
}
