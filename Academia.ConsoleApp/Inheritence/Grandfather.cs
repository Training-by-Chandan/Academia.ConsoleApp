using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.ConsoleApp.Inheritence
{
    public class Grandfather
    {
        public Grandfather()
        {

        }

        public Grandfather(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public string LastName { get; set; }
        public string FirstName { get; set; }


        protected string SomeFamilySecret { get; set; }
        private string SomePersonalSecret { get; set; }

        public virtual void Display()
        {
            
            Console.WriteLine($"Grandfather => {this.FirstName} {this.LastName}");
        }
    }
}
