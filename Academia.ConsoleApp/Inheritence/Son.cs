using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.ConsoleApp.Inheritence
{
    public sealed class Son : Father
    {
        public Son():base()
        {

        }

        public Son(string FirstName, string LastName) : base(LastName, FirstName)
        {

        }
        public void Display()
        {
            base.Display();
            Console.WriteLine($"Son => {this.FirstName} {this.LastName}");
        }
    }

    public class GrandSon :Father
    {

    }
}
