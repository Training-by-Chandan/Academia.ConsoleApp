using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.ConsoleApp.Collections
{
    public class Students
    {
        public Students()
        {

        }

        public Students(string fname, string lname, double percent)
        {
            this.FName = fname;
            this.LName = lname;
            this.Percentage = percent;
        }

        public Students(string fname, string lname)
        {
            this.FName = fname;
            this.LName = lname;
            
        }
        public string FName { get; set; }
        public string LName { get; set; }

        public string FullName
        {
            get
            {
                return $"{this.FName} {this.LName}";
            }
        }
        private double _percentage;
        public double Percentage
        {
            get
            {
                return _percentage;
            }
            private set
            {
                if (_percentage >100 || _percentage < 0)
                {
                    _percentage = 0;
                    //throw new Exception("percentage cannot be greater than 100 or less than 0");
                }

            }
        }
    }
}
