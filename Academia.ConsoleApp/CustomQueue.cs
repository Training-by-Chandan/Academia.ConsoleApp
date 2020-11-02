using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.ConsoleApp
{
    public class CustomQueue
    {

        public int[] container = new int[10];
        public int count = 0;
        public void Enqueue(int a)
        {
            if (count<=9)
            {
                container[count] = a;
                count++;
            }
        }

        public int Dequeue()
        {
            int ret = container[0];
            for (int i = 0; i < count-1; i++)
            {
                container[i] = container[i + 1];
            }
            container[count - 1] = 0;
            count--;
            return ret;
        }

        //public int Peek()
        //{

        //}

        public void DisplayAll()
        {
            Console.WriteLine(string.Join(',', container));
        }
    }

    public class DynamicCustomQueue
    {
        public int[] container = new int[0];
        
        public void Enqueue(int a)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length-1] = a;
        }

        public int Dequeue()
        {
            int ret = container[0];
            for (int i = 0; i < container.Length - 1; i++)
            {
                container[i] = container[i + 1];
            }
            Array.Resize(ref container, container.Length - 1);

            return ret;
        }

        //public int Peek()
        //{

        //}

        public void DisplayAll()
        {
            Console.WriteLine(string.Join(',', container));
        }
    }

    public class GenericDynamicCustomQueue<T>
    {
        public T[] container = new T[0];

        public void Enqueue(T a)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length - 1] = a;
        }

        public T Dequeue()
        {
            T ret = container[0];
            for (int i = 0; i < container.Length - 1; i++)
            {
                container[i] = container[i + 1];
            }
            Array.Resize(ref container, container.Length - 1);

            return ret;
        }

        //public int Peek()
        //{

        //}

        public void DisplayAll()
        {
            Console.WriteLine(string.Join(',', container));
        }
    }
}
