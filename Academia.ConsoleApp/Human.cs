using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.ConsoleApp
{
    class Human : Animal
    {
        public string Ethnicity { get; set; }
        public Gender Genders { get; set; } //male mail m

        
    }

    public enum Gender
    {
        Male=5, 
        Female=6, 
        Other=7
    }

    class Animal
    {
        public string Name { get; set; }
        public decimal Height { get; set; }
        public string ScientificName { get; set; }
    }

    struct HumanStruct 
    {
        public string Name;
        public decimal Height;
    }

    struct NewStruct
    {

    }
}
