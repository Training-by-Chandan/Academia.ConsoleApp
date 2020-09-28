using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.ConsoleApp.Interface
{
    public interface IShape : IArea, IPerimeter
    {
        
    }

    public interface IArea
    {
        decimal Area();
    }

    public interface IPerimeter
    {
        decimal Perimeter();
    }

    public class Rectangle : IShape
    {
        public decimal Length { get; set; }
        public decimal Breadth { get; set; }

        public decimal Perimeter()
        {
            return 2 * (Length + Breadth);
        }
        public decimal Area()
        {
            return Length * Breadth;
        }
    }

    public class Circle : IShape
    {
        const decimal pi = 3.1415M;
        public decimal Radius { get; set; }
        public decimal Perimeter()
        {
            return 2 * pi * Radius;
        }

        public decimal Area()
        {
            return pi * (Radius * Radius);
        }
    }

    public enum Shape
    {
        None, 
        Rectangle, 
        Circle
    }
}
