using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.ConsoleApp.DelegatesAndEvent
{
    public class DelegateExample
    {
        
        public delegate int AddHandler(int a, int b);
        public event AddHandler AddEvent;

        public DelegateExample()
        {
            
        }

        public void Method1(int a, int b)
        {
            
            AddEvent?.Invoke(a, b);
        }

        public void Method2()
        {
            int a = 1;
            int b = 2;
            AddEvent?.Invoke(a, b);
        }
    }

    public class DelegateImpl
    {
        public DelegateExample d1 = new DelegateExample();


        public DelegateImpl()
        {
            d1.AddEvent += D1_AddEvent;
        }
        public void Initiate()
        {
            d1.Method1(5,6);

        }

        public void Initiate2()
        {
            d1.Method2();
        }

        private int D1_AddEvent(int a, int b)
        {
            Console.WriteLine("Event 1");
            Console.WriteLine($"{a} + {b} = {a + b}");
            return a + b;
        }
        
        public void AddNextEvent()
        {
            d1.AddEvent += D1_AddEvent2;
        }

        private int D1_AddEvent2(int a, int b)
        {
            Console.WriteLine("Event 2");
            Console.WriteLine($"{a} + {b} = {a + b}");
            return a + b;
        }
    }
}
