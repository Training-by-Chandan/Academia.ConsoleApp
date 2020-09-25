using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.ConsoleApp.Inheritence
{
    public class Father : Grandfather
    {
        public Father():base()
        {

        }
        public Father(string LastName,string FirstName): base(FirstName, LastName)
        {

        }
        public void SetNames(string FirstName, string LastName)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            SomeFamilySecret = "";
            
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Father => {this.FirstName} {this.LastName}");
        }
    }
}
