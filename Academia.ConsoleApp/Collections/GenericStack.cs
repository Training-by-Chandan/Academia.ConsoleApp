using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.ConsoleApp.Collections
{
    public class GenericStack<T1, T2> where T1 : class
    {
        public T1 Template1;
        public T2 Template2;

        public void DisplayTypesofTemplates()
        {
            Console.WriteLine($"Type of T1 is {typeof(T1)}");
            Console.WriteLine($"Type of T2 is {typeof(T2)}");
        }
    }
}
