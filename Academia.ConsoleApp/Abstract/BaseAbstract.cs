using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.ConsoleApp.Abstract
{
    public abstract class AShape
    {
        public abstract decimal Area(); //declare

        public decimal Perimeter() //define
        {
            return 0;
        }
    }

    public class Rectangle: AShape
    {
        public override decimal Area()
        {
            this.Perimeter();
            return 0;
        }

        public new decimal Perimeter()
        {
            base.Perimeter();
            return 1;
        }

       
    }

    //public abstract class AArea
    //{
    //    public abstract decimal Area(); 
    //}

    //public abstract class APerimeter
    //{
    //    public abstract decimal Perimeter();
    //}
}
