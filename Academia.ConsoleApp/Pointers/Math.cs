using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.ConsoleApp.Pointers
{
    public class Math
    {
        public int Add1byVal(int a)
        {
            return a++;
        }

       public int Add1byRef(ref int a)
        {
            return a++;
        }
    }


}
