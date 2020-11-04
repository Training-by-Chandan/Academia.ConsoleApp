using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    
    [Display(Name ="Login")]
    
    public class LoginModel
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [My("Academia", TimeinSeconds =20)]
        [My("College")]
        public string Password { get; set; }
    }

    public class AcademiaException : Exception
    {
        public AcademiaException(string message):base(message)
        {

        }
    }

    public class NewException : Exception
    {
        public NewException(string message) : base(message)
        {

        }
    }

    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true)]
    
    public class MyAttribute: Attribute
    {
        public string Name { get; set; }
        public int TimeinSeconds { get; set; }
        public MyAttribute(string name)
        {
            this.Name = name;
        }
    }

    

    class Animal
    {
        [DataType(DataType.Text)]
        [Required]
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
