using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.ConsoleApp
{
    // nothing then public
    // public, protected, private, internal, internal protected
    //class Student 
    //{


    //}

    public class Student
    {
        private string _name = "";
        private string _class = "";
        #region Construtor Overloading
            public Student()
            {
                _class = "6th Sem";
            }

            public Student(string name, string classname)
            {
                _name = name;
                _class = classname;
            }

            public Student(string name)
            {
                _name = name;
            }
        #endregion

        #region Function Overloading in Display function 
            public void Display()
            {
                Console.WriteLine("Name = " + _name + "\nClass = " + _class);
                Console.WriteLine(string.Format("Name = {0}\n Class = {1}", _name, _class));
                Console.WriteLine($"Name = {_name}\nClass = {_class}");
            }
            public void Display(string name)
            {

            }
            public void Display(string name, string classname)
            {
            
            }
        #endregion

        //not oftenly used
        ~Student()
        {
            _name = null;
            _class = null;
        }

    }
}


