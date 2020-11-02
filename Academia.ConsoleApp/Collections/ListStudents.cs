using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academia.ConsoleApp.Collections
{
    public class ListStudents
    {
        public List<Students> St = new List<Students>();
        
        public void AddStudent(string fname, string lname, double percent)
        {
            var student = new Students(fname, lname, percent);
            St.Add(student);
        }

        public void DisplayAll()
        {
            foreach (var item in St)
            {
                Console.WriteLine($"{item.FullName} => {item.Percentage}");
            }
        }

        public void DisplaybyFName(string name)
        {
            var listlinq = (from s in St where s.FName.StartsWith(name) select s);
            var list = St.Where(p => p.FName.StartsWith(name)).Select(p=>p); // lambda expression

            foreach (var item in list)
            {
                Console.WriteLine($"{item.FullName} => {item.Percentage}");
            }
        }

    }
}
